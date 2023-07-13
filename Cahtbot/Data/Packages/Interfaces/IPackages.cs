using Chatbot.Models;
using System.Collections.Generic;

namespace Chatbot.Data.Packages.Interfaces
{
    public interface IPackages
    {
        List<Package> GetAllPackages();
        void CreatePackage(Package package);
       // Task<Backages> UpdateBackge(Backages backage);
      //  Task<Backages> DeleteBackge(int Id);


    }
}
