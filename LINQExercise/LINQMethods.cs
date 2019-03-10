using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace LINQExercise
{
   public class LINQMethods
    {
        
        public IEnumerable<int> RemainderofZero()
        {
            IEnumerable<int> listofnumbers = new List<int>() { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            IEnumerable<int> noremainder = listofnumbers.Where(x => x % 2 == 0);

            return noremainder;
        }

        public IEnumerable<int> RangeofNumbersfrom1to11()
        {
            IEnumerable<int> listofnumbers = new List<int>() { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };
            IEnumerable<int> RangeOneToEleven = listofnumbers.SkipWhile(x => x < 1).TakeWhile(x => x < 12); 

            return RangeOneToEleven;
        }

        public IEnumerable<int> SquareofANumber()
        {
            IEnumerable<int> listofnumbers = new List<int>() {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            IEnumerable<int> squareofnumber = listofnumbers.Select(x => x * x);
            return squareofnumber;
        }

        public string FrequencyofNumbers()
        {
           int[] numberstocount = new int[] { 2, 2, 5, 5, 6, 7, 5, 5, 5, 8, 1, 1, 1, 9 };

            var newItems = numberstocount.GroupBy(x => x)
                .Select(grp => new { Number = grp.Key, Count = grp.Count()});

            string output = string.Join("," , newItems.Select(x => $"{{Number = {x.Number}, Count = {x.Count}"));

            
            return output;
        }
    
        public string FrequencyofCharacters()
        {
            string[] characters = new string[] { "a", "p", "p", "l", "e" };

            var characterItems = characters.GroupBy(x => x)
                .Select(grp => new { Character = grp.Key, Count = grp.Count() });

            string charactercount = string.Join(",", characterItems.Select(x => $"Character = {x.Character}, Count = {x.Count}"));

            return charactercount;
        }


        public IEnumerable<string> NamesOfDaysofWeek()
        {
            List<string> DaysofWeek = new List<string> { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };

            IEnumerable<string> weekdays = DaysofWeek;


            foreach (var item in weekdays)
            {
                Console.WriteLine("item");
            }


            return weekdays;

        }

        public string FrequencyofNumbersandMultiplication()
        {
          int[] numbers = new int[] { 5, 1, 9, 2, 3, 7, 4, 5, 6, 8, 7, 6, 3, 4, 5, 2 };

          var numberfrequency = numbers.GroupBy(x => x)
                .Select(grp => new { Number = grp.Key, Count = grp.Count(), Multiplication = grp.Key * grp.Count()});


            //IEnumerable<int> frequencyandsquared;
            //numbers.Select(x => x * x);

            // numbers.OrderBy(x => );

            string output = string.Join(",", numberfrequency.Select(x => $"{{Number = {x.Number}, Count = {x.Count}, Multiplication = {x.Multiplication}"));
            
            return output;
        }

            public string StartsandEndsWith(string startLetter, string endLetter)
        {
            List<string> countrys = new List<string> { "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS" };

            IEnumerable<string> findcountry = countrys.Where(x => x.StartsWith(startLetter, StringComparison.InvariantCultureIgnoreCase)).Where(y => y.EndsWith(endLetter, StringComparison.InvariantCultureIgnoreCase));

            string firstcountry = findcountry.First();
            return firstcountry;
        }

        public IEnumerable<int> Displaygreaterthan80()
        {
            List<int> somenumbers = new List<int> { 55, 200, 740, 76, 230, 482, 95 };

            IEnumerable<int> moreThan80 = somenumbers.Where(x => x > 80);

            return moreThan80;
        }

        public IEnumerable<int> Displaymorethanuserinput(int displayvalue, List<int> userlist)
        {
            
            IEnumerable<int> morethanuserinput = userlist.Where(x => x > displayvalue);

            return morethanuserinput;
        }

        public IEnumerable<int> DisplaybynthRecord(int nrecords)
        {
            int[] grades = new int[] { 50, 70, 100, 100, 20, 10 };
            IEnumerable<int> orderedgrade = grades.OrderBy(x => x);
            IEnumerable<int> Displaynthrecord = orderedgrade.Take(nrecords);

            return Displaynthrecord;
        }

        public IEnumerable<int> Findnthgrade(int input)
        {
            int[] grades = new int[] { 100, 85, 62, 95, 95, 70, 20, 50, 45 };
            IEnumerable<int> nthgrade = grades.OrderBy(x => x).Select(x => input);

            return nthgrade;
        }

        public IEnumerable<string> ConverttoString()
        {
            string[] elements = new string[] { "cat", "dog", "rat" };

            IEnumerable<string> convertion = elements.Select(x => elements.ToString());
            return convertion;
        }

        public void UppercaseString()
        {
            var sentence = "this IS a STRING";
            var sentencesplit = sentence.Split();

            var uppers = sentencesplit.Where(x => x.ToUpper());

        }
       // public IEnumerable<char> RemovebyFilter(char filter)
        //{
          //  List<char> Items = new List<char>() { 'm', 'n', 'o', 'p', 'q' };

            //Items.Remove(filter);

            //IEnumerable<char> Filterby = Items;
       // }

        public IEnumerable<char> RemoveRangeofItems(int startindex, int numberofelementstoremove)
        {
            List<char> Items = new List<char>() { 'm', 'n', 'o', 'p', 'q' };

            for (int i = 0; i < numberofelementstoremove; i++)
            {
                Items.RemoveAt(startindex);
            }

            return Items;
        }


        public IEnumerable<string> minimumLengthofString(int input)
        {
            string[] stringarray = new string[] { "this", "is", "a", "string" };

            IEnumerable<string> minimumstring = stringarray.Where(x => x.Length > 4);

            return minimumstring;
        }

        public IEnumerable<char> RemoveItemsfromListbyIndex(int indextoremove)
        {
            List<char> Items = new List<char>() { 'm', 'n', 'o', 'p', 'q' };
            Items.RemoveAt(indextoremove);
            IEnumerable<char> Filterby = Items;

            return Items;
        }

        public string CountingFileExtensions()
        {
            string[] files = new string[] { "a.frx", "aaa.txt", "ttt.txt", "mox.txt", "xoe.dbf", "wer.pdf", "asw.pdf", "bcs.fml", "bbb.xml" };

            List<string> fileextensions = new List<string>();
            foreach (var item in files)
            {
                var fileex = item.Split('.').ToString();
                fileextensions.Add(fileex);
            }

            var countFileextensions = fileextensions.GroupBy(x => x)
                .Select(grp => new { FileExtension = grp.Key, Count = grp.Count() });

            string output = string.Join(",", countFileextensions.Select(x => $"{{The File Extension = {x.FileExtension}, Count = {x.Count}"));

            return output;
        }

        public void AverageFileSize()
        {
            string[] dirfiles = Directory.GetFiles("C:/dir");

            var avg = dirfiles.Select(file => new FileInfo(file).Length).Average();

            Console.WriteLine("The average file size is {0} MB", avg);

            
        }



        public void CartesianListwithTwoSets()
        {
            List<string> letterList = new List<string>() { "X", "Y", "Z" };
            List<int> numberlist = new List<int>() { 1, 2, 3, 4};


            var Test = letterList.SelectMany(l => numberlist, (l, n) => new {LetterList = l, Numberlist = n });
            // var output = numberlist.Join(letterList, x => x, y => y, (x, y) => x);

            

            
         
            //foreach (var item in output)
            //{
              //  Console.WriteLine(item);
           // }
        }

        public void CartesianListwithThreeSets()
        {
            List<string> letterList = new List<string>() { "X", "Y", "Z" };
            List<int> numberlist = new List<int>() { 1, 2, 3, 4 };
            List<string> colorlist = new List<string>() { "Green", "Orange" };

            var Test = letterList.SelectMany(l => numberlist, (l, n) => new { LetterList = l, Numberlist = n });
           

        }

        public void InnerJoiningList()
        {

            List<Item> itemname = new List<Item> {
                new Item {Id = 1, ItemDescription = "Biscuit"},
                new Item {Id = 2, ItemDescription = "Chocolate"},
                new Item {Id = 3, ItemDescription = "Butter"},
                new Item {Id = 3, ItemDescription = "Butter"},
                new Item {Id = 3, ItemDescription = "Butter"},
                new Item {Id = 4, ItemDescription = "Brade"},
                new Item {Id = 4, ItemDescription = "Brade"}
            };

            List<Price> itemprice = new List<Price>
            {
                new Price{Itemid = 1, PurchaseQuantity = 458},
                new Price{Itemid = 2, PurchaseQuantity = 650},
                new Price{Itemid = 2, PurchaseQuantity = 800},
                new Price{Itemid = 3, PurchaseQuantity = 900},
                new Price{Itemid = 3, PurchaseQuantity = 900},
                new Price{Itemid = 4, PurchaseQuantity = 700},
                new Price{Itemid = 4, PurchaseQuantity = 650},
            };


            var RightJoinoutput = itemname.Join(itemprice, x => x.Id, y => y.Itemid, (x, y) => x);
  
        }

        public void LeftJoiningList()
        {
            List<string> itemnam = new List<string> { "Biscuit", "Chocolate", "Butter", "Butter", "Butter", "Brade", "Brade", "Honey"};
            List<int> purchaseprice = new List<int> { 458, 650, 800, 900, 900, 700, 650 };


            List<Item> itemname = new List<Item> {
                new Item {Id = 1, ItemDescription = "Biscuit"},
                new Item {Id = 2, ItemDescription = "Chocolate"},
                new Item {Id = 3, ItemDescription = "Butter"},
                new Item {Id = 3, ItemDescription = "Butter"},
                new Item {Id = 3, ItemDescription = "Butter"},
                new Item {Id = 4, ItemDescription = "Brade"},
                new Item {Id = 4, ItemDescription = "Brade" },
                new Item {Id = 5, ItemDescription = "Honey"}
            };

            List<Price> itemprice = new List<Price>
            {
                new Price{Itemid = 1, PurchaseQuantity = 458},
                new Price{Itemid = 2, PurchaseQuantity = 650},
                new Price{Itemid = 2, PurchaseQuantity = 800},
                new Price{Itemid = 3, PurchaseQuantity = 900},
                new Price{Itemid = 3, PurchaseQuantity = 900},
                new Price{Itemid = 4, PurchaseQuantity = 700},
                new Price{Itemid = 4, PurchaseQuantity = 650},
                new Price{Itemid = 5, PurchaseQuantity = 800}
            };

            var leftJoinList = itemname.GroupJoin(itemprice, x => x.Id, y => y.Itemid, (x, y) => x);

        }

        public void OuterJoiningList()
        {
            List<Item> itemname = new List<Item> {
                new Item {Id = 1, ItemDescription = "Biscuit"},
                new Item {Id  = 2, ItemDescription = "Chocolate"},
                new Item {Id  = 3, ItemDescription = "Butter"},
                new Item {Id = 3, ItemDescription = "Butter"},
                new Item {Id = 3, ItemDescription = "Butter"},
                new Item {Id = 4, ItemDescription = "Brade"},
                new Item {Id = 4, ItemDescription = "Brade" },
                new Item {Id = 5, ItemDescription = "Honey"}
            };

            List<Price> itemprice = new List<Price>
            {
                new Price{Itemid = 1, PurchaseQuantity = 458},
                new Price{Itemid = 2, PurchaseQuantity = 650},
                new Price{Itemid = 2, PurchaseQuantity = 800},
                new Price{Itemid = 3, PurchaseQuantity = 900},
                new Price{Itemid = 3, PurchaseQuantity = 900},
                new Price{Itemid = 4, PurchaseQuantity = 700},
                new Price{Itemid = 4, PurchaseQuantity = 650},
                new Price{Itemid = 5, PurchaseQuantity = 800}
            };

            //var OuterJoinList = itemname.GroupJoin(itemprice, x => x.Id, y => y.Itemid, (x, y) => new { Item = x, Price = y })
            //  .SelectMany(x => x.Item.Id,
            // (x, y) => new { new { Item = x, Price = y } });
            //;

            var OuterJoinList = itemname.GroupJoin(itemprice, itemn => itemn.Id, itemp => itemp.Itemid, (itemn, itemp) => new { Key = itemn.ItemDescription, Price = itemp });
               
        }

        public void DisplayCountriesinAscendingOrder()
        {
            List<string> countrys = new List<string> { "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS" };
            var output = countrys.OrderBy(x => x);
        }

        public void SplitCollectionofCountries()
        {
            string[] countrys = new string[]{ "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS" };
            string output;
            foreach (var item in Enumerable.Range(0, countrys.Length))
            {
               var countriesgroups = countrys.GroupBy(x => x[item] / 3);

                foreach(var newitem in countriesgroups)
                {
                    output = string.Join("; ", countriesgroups.ToString());
                }
            }

            
        }
        public void ArrangeDistinctElements()
        {
            List<Item> itemname = new List<Item> {
                new Item {Id = 1, ItemDescription = "Biscuit"},
                new Item {Id  = 2, ItemDescription = "Chocolate"},
                new Item {Id  = 3, ItemDescription = "Butter"},
                new Item {Id = 3, ItemDescription = "Butter"},
                new Item {Id = 3, ItemDescription = "Butter"},
                new Item {Id = 4, ItemDescription = "Brade"},
                new Item {Id = 4, ItemDescription = "Brade" },
                new Item {Id = 5, ItemDescription = "Honey"}
            };

            var uniqueitems = itemname.Select(x => x.Id).Distinct();
        }

        public class Item
        {
            public int Id { get; set; }

            public string ItemDescription { get; set; }
        }

        public class Price
        {
            public int Itemid { get; set; }
            public int PurchaseQuantity { get; set; }
        }
    }
}

