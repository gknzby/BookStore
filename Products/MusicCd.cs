using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    class MusicCd : Product
    {
        private string type;
        private string singer;

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
        // Singer - Getter / Setter
        public string Singer
        {
            get
            {
                return singer;
            }
            set
            {
                singer = value;
            }
        }

        private static MusicCd musicCd; // Singleton Class Object.
        private static List<MusicCd> musicCds; // All MusicCDs.

        // Default Constructor - Start
        public MusicCd()
        {

        }
        // Default Constructor - End

        // Singleton Patern Constructor - Start
        public static MusicCd MusicCdX()
        {
            if (musicCd == null)
            {
                musicCd = new MusicCd();
                musicCds = new List<MusicCd>();
            }
            return musicCd;
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
            propers[5] = singer;
            propers[6] = type;

            return propers;
        }
        // Print All Details Of Product - End

        // Clear MusicCds List - Start
        public void clearMusicCds()
        {
            musicCds.Clear();
        }
        // Clear MusicCds List - End

        // List All MusicCds - Start
        public List<MusicCd> listAllMusicCds()
        {
            return musicCds;
        }
        // List All MusicCds - End

        // Sync All MusicCds With Database - Start
        public void syncAllMusicCds(List<MusicCd> x)
        {
            musicCds.Clear();
            musicCds = x;
        }
        // Sync All MusicCds With Database - End

        // Add MusicCd To List - Start
        public void addMusicCd(long idX, string nameX, double priceX, string typeX, string singerX, string coverPagePictureX)
        {
            musicCds.Add(new MusicCd
            {
                Id = idX,
                Name = nameX,
                Price = priceX,
                Type = typeX,
                Singer = singerX,
                CoverPagePicture = coverPagePictureX
            });
        }
        // Add MusicCd To List - End

        // Remove MusicCd From List - Start
        public void removeMusicCd(long idX)
        {
            int index = -1;
            for (int i = 0; i < musicCds.Count; i++)
            {
                if (musicCds[i].Id == idX)
                {
                    index = i;
                    break;
                }
            }
            musicCds.RemoveAt(index);
        }
        // Remove MusicCd From List - End

        // Update MusicCd At List - Start
        public void updateMusicCd(long idX, string nameX, double priceX, string typeX, string singerX)
        {
            int index = -1;
            for (int i = 0; i < musicCds.Count; i++)
            {
                if (musicCds[i].Id == idX)
                {
                    index = i;
                    break;
                }
            }
            musicCds[index].Name = nameX;
            musicCds[index].Price = priceX;
            musicCds[index].Type = typeX;
            musicCds[index].Singer = singerX;
        }
        // Update MusicCd At List - End

        // Add Or Update Cover Page Picture Of Product - Start
        public void AddCoverPagePicture(long idX, string pictureNameX)
        {
            int index = -1;
            for (int i = 0; i < musicCds.Count; i++)
            {
                if (musicCds[i].Id == idX)
                {
                    index = i;
                    break;
                }
            }
            musicCds[index].CoverPagePicture = pictureNameX;
        }
        // Add Or Update Cover Page Picture Of Product - Start
    }
}