using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;
namespace SpotifyCloneUI
{
    class HashTableSinger
    {
        
        public string[] singersForSearch;
        public string[] singerName;
        public string[] songName;
        public string[] id;
        public string[] songLink;
        public string[] imageLink;
        public string[] lyrics;
        int tableSize;
        public HashTableSinger(int count)
        {
           
            singersForSearch = new string[count];
            singerName = new string[count];
            songName = new string[count];
            id=new string[count];
            songLink= new string[count];
            imageLink= new string[count];
            lyrics= new string[count];
            tableSize = count;
            for(int i = 0; i < count; i++)
            {
                singersForSearch[i] = "";
            }
        }

        public void AddSong(string singer,string song, string uid,string songlink,string lyr,string imglink)
        {
            int index;
            int num=0;
            string forSearch = makeValidString(singer);
            for(int i = 0; i < forSearch.Length; i++)
            {
                num += forSearch[i];
            }
            index = num % tableSize;
            if (singersForSearch[index] == "")
            {
                singersForSearch[index] = forSearch;
                singerName[index] = singer;
                songName[index] = song;
                id[index] = uid;
                imageLink[index] = imglink;
                lyrics[index] = lyr;
                songLink[index] = songlink;
            }
            else
            {
                index = LinearProbe(index);
                singersForSearch[index] = forSearch;
                singerName[index] = singer;
                songName[index] = song;
                id[index] = uid;
                imageLink[index] = imglink;
                lyrics[index] = lyr;
                songLink[index] = songlink;
            }
        }

        private int LinearProbe(int ind)
        {
            ind++;
            while (true)
            {
                if (singersForSearch[ind] == "")
                {
                    break;
                }
                else
                {
                    ind++;
                }
            }

            return ind;
        }
        private int getIndex(string searchQ)
        {
            int num = 0;
            int index = 0;
            bool found = false;
            int j = 0;
            searchQ = makeValidString(searchQ);
            for(int i = 0; i < searchQ.Length; i++)
            {
                num += searchQ[i];
            }
            index = num % tableSize;
            if (singersForSearch[index] == searchQ)
            {
                found = true;
                return index;
            }
            else
            {
                while (true)
                {
                    if (j == tableSize)
                    {
                        return -1;
                    }
                    index++;
                    if (singersForSearch[index] == searchQ)
                    {
                        return index;
                    }
                    j++;
                }
            }
            
            return -1;
        }

        private string makeValidString(string str)
        {
            string final = "";
            for (int i = 0; i < str.Length; i++)
            {
                if ((str[i]>='a' && str[i]<='z') || (str[i]>='A' && str[i] <= 'Z'))
                {
                    final += str[i];
                }
            }
           
            return final.ToLower();
        }

       
    }
}
