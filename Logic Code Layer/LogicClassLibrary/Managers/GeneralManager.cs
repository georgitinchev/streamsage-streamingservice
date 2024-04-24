﻿using DTOs;
using LogicClassLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicClassLibrary.Managers
{
	public class GeneralManager
	{
		private User? currentUser;
		private List<Movie>? searchResults;

        public virtual Entity? TransformDTOtoEntity(object dto)
        {
            throw new NotImplementedException("This method should be overridden in a derived class.");
        }

        public void Create()
        {
            throw new NotImplementedException();
        }

        public void Read()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public void fetchUserData(int userId)
		{

		}

		public void fetchMovieData(int movieId)
		{

        }

		public void fetchReviewData(int reviewId)
		{

        }

		public void fetchInterpretationData(int interpretationId)
		{

        }	

		public void searchMovies(string searchQuery)
		{

        }

		public void executeQuery(string query)
		{

        }

		public void fetchResults()
		{

        }

		public void executeAnalysis()
		{

        }

		public void generateRecommendations()
		{

        }
	}
}
