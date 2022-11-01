using CarRental.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Routing;
using System.Web.Http.Filters;
using System.Web.Mvc;

namespace CarRental.Services
{

    public class CustomAuthorize : AuthorizationFilterAttribute
    {
        
    }
}
