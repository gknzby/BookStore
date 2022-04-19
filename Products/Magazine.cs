using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    class Magazine : Product
    {
        private string type;
        private DateTime issue;

        // Type - Getter / Setter
        public string Type
        {
            get
            {
                return type;
            }
            set
            {
                type = value;
            }
        }
        // Issue - Getter / Setter
        public DateTime Issue
        {
            get
            {
                return issue;
            }
            set
            {
                issue = value;
            }
        }

        private static Magazine magazine; // Singleton Class Object.
        private static List<Magazine> magazines; // All Magazines.

        // Default Constructor - Start
        public Magazine()
        {

        }
        // Default Constructor - End

        // Singleton Patern Constructor - Start
        public static Magazine MagazineX()
        {
            if (magazine == null)
            {
                magazine = new Magazine();
                magazines = new List<Magazine>();
            }
            return magazine;
        }
        // Singleton Patern Constructor - End

        // Print All Details Of Product - Start
        public override string[] printProperties()
        {
            string[] propers = new string[7];

            propers[0] = Id.ToString();
            propers[1] = Name.ToString();
            propers[2] = Price.ToString();
            propers[3] = ProductType.ToString();
            propers[4] = CoverPagePicture;
            propers[5] = issue.ToString();
            propers[6] = type;

            return propers;
        }
        // Print All Details Of Product - End

        // Clear Magazines List - Start
        public void clearMagazines()
        {
            magazines.Clear();
        }
        // Clear Magazines List - End

        // List All Magazines - Start
        public List<Magazine> listAllMagazines()
        {
            return magazines;
        }
        // List All Magazines - End

        // Sync All Magazines With Database - Start
        public void syncAllMagazines(List<Magazine> x)
        {
            magazines.Clear();
            magazines = x;
        }
        // Sync All Magazines With Database - End

        // Add Magazine To List - Start
        public void addMagazine(long idX, string nameX, double priceX,  string typeX,DateTime issueX, string coverPagePictureX)
        {
            magazines.Add(new Magazine
            {
                Id = idX,
                Name = nameX,
                Price = priceX,
                Type = typeX,
                Issue = issueX,
                CoverPagePicture = coverPagePictureX
            });
        }
        // Add Magazine To List - End

        // Remove Magazine From List - Start
        public void removeMagazine(long idX)
        {
            int index = -1;
            for (int i = 0; i < magazines.Count; i++)
            {
                if (magazines[i].Id == idX)
                {
                    index = i;
                    break;
                }
            }
            magazines.RemoveAt(index);
        }
        // Remove Magazine From List - End

        // Update Magazine At List - Start
        public void updateMagazine(long idX, string nameX, double priceX, string typeX, DateTime issueX)
        {
            int index = -1;
            for (int i = 0; i < magazines.Count; i++)
            {
                if (magazines[i].Id == idX)
                {
                    index = i;
                    break;
                }
            }
            magazines[index].Name = nameX;
            magazines[index].Price = priceX;
            magazines[index].Type = typeX;
            magazines[index].Issue = issueX;
        }
        // Update Magazine At List - End

        // Add Or Update Cover Page Picture Of Product - Start
        public void AddCoverPagePicture(long idX, string pictureNameX)
        {
            int index = -1;
            for (int i = 0; i < magazines.Count; i++)
            {
                if (magazines[i].Id == idX)
                {
                    index = i;
                    break;
                }
            }
            magazines[index].CoverPagePicture = pictureNameX;
        }
        // Add Or Update Cover Page Picture Of Product - End
    }
}