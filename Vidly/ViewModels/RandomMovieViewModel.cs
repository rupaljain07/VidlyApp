﻿using System;
using System.Collections.Generic;
using System.Linq;
using Vidly.Models;
using System.Web;

namespace Vidly.ViewModels
{
    public class RandomMovieViewModel
    {
        public Movie Movie { get; set; }
        public List<Customer> Customers { get; set; }
    }
}