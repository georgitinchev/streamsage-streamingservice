using DTOs;
using LogicClassLibrary.Exception;
using LogicClassLibrary.Helpers;
using LogicClassLibrary.Interface.Helpers;
using LogicClassLibrary.Interface.Manager;
using LogicClassLibrary.Interface.Service;

namespace LogicClassLibrary.Managers
{
    public class PaginatorManager : IPaginatorManager
    {
        private Dictionary<Type, object> _paginators = new Dictionary<Type, object>();

        public PaginatorManager(IUserService userService, IMovieService movieService, IReviewService reviewService, IInterpretationService interpretationService, int defaultPageSize)
        {
            _paginators[typeof(UserDTO)] = new Paginator<UserDTO>(userService.GetUsersPage, defaultPageSize);
            _paginators[typeof(MovieDTO)] = new Paginator<MovieDTO>(movieService.GetMoviesPage, defaultPageSize);
            _paginators[typeof(ReviewDTO)] = new Paginator<ReviewDTO>(reviewService.GetReviewsPage, defaultPageSize);
            _paginators[typeof(InterpretationDTO)] = new Paginator<InterpretationDTO>(interpretationService.GetInterpretationsPage, defaultPageSize);
        }

        public IPaginator<T> GetPaginator<T>()
        {
            if (_paginators.TryGetValue(typeof(T), out var paginator))
            {
                return paginator as IPaginator<T>;
            }
            else
            {
                throw new PaginatorException($"No paginator found for type {typeof(T)}");
            }
        }

        public void UpdatePageSize(int pageSize)
        {
            foreach (var paginator in _paginators.Values)
            {
                (paginator as IPaginator<object>).PageSize = pageSize;
            }
        }
    }
}
