using LogicClassLibrary.Interface.Helpers;
using System;
using System.Collections.Generic;

namespace LogicClassLibrary.Helpers
{
    public class Paginator<T> : IPaginator<T>
    {
        private readonly Func<int, int, List<T>> _loadPageFunc;
        private int _currentPage;
        private bool _isLoadingPage;

        public Paginator(Func<int, int, List<T>> loadPageFunc, int pageSize)
        {
            _loadPageFunc = loadPageFunc;
            PageSize = pageSize;
        }

        public int CurrentPage => _currentPage;

        public int PageSize { get; set; }

        public List<T> LoadPage(int pageNumber)
        {
            _isLoadingPage = true;
            _currentPage = pageNumber;
            var result = _loadPageFunc(pageNumber, PageSize);
            _isLoadingPage = false;
            return result;
        }

        public List<T> NextPage()
        {
            if (_isLoadingPage)
            {
                return LoadPage(_currentPage);
            }

            _isLoadingPage = true;
            _currentPage++;
            var result = LoadPage(_currentPage);
            _isLoadingPage = false;
            return result;
        }

        public List<T> PreviousPage()
        {
            if (_isLoadingPage)
            {
                return LoadPage(_currentPage);
            }

            _isLoadingPage = true;
            _currentPage = Math.Max(0, _currentPage - 1);
            var result = LoadPage(_currentPage);
            _isLoadingPage = false;
            return result;
        }
    }
}
