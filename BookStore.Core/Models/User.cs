using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Core.Models
{
	public class User:IdentityUser
	{
		public string? Lastname { get; set; }
		public string? Firstname { get; set; }
	}
}
