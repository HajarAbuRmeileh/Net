using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Chatbot.Models;
using Chatbot.Data.Packages.Interfaces;
using Chatbot;

namespace WebAPI.Data.Packages.Services
{
    public class PackageService : IPackages
    {
        public readonly ChatbotContext _context;
        public PackageService(ChatbotContext context)
        {
            _context = context;
        }

        public void CreatePackage(Package Package)
        {
            try
            {
                _context.Packages.Add(Package);
                 _context.SaveChanges();
               // return Package;
            }catch (Exception ex)
            {
                throw;
            }
        }

        public List<Package> GetAllPackages()
        {
            return  _context.Packages.ToList();
        }
    }
}
