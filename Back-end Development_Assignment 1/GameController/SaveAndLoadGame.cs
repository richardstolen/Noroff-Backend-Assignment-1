using CsvHelper;
using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Back_end_Development_Assignment_1.GameController
{
    public class SaveAndLoadGame
    {
        public static void saveGame(Hero hero)
        {
            string file = "savegame.csv";

            using (StreamWriter sw = new StreamWriter(file))
            {
                using (CsvWriter csv = new CsvWriter(sw, CultureInfo.InvariantCulture))
                {


                    csv.WriteRecord(hero);
                    csv.NextRecord();

                    foreach (var record in hero.EquippedItems)
                    {
                        csv.WriteRecords(record);

                        foreach (var item in record)
                        {
                            PropertyInfo[] properties = item.GetType().GetProperties();
                            foreach (PropertyInfo property in properties)
                            {
                                csv.WriteField(property.GetValue(item));
                            }
                        }

                        csv.NextRecord();
                    }
                }
            }
        }

        public static Hero loadGame()
        {
            string file = "savegame.csv";

            using (StreamReader sr = new StreamReader(file))
            {
                using (CsvReader reader = new CsvReader(sr, CultureInfo.InvariantCulture))
                {
                    reader.Read();

                    Hero hero = reader.GetRecord<Hero>();

                    return hero;
                }
            }
        }

        public class HeroMap : ClassMap<Hero>
        {
            public HeroMap()
            {
                Map(p => p.Name);
                Map(p => p.Level);
                Map(p => p.Experience);
                Map(p => p.Health);
                Map(p => p.LevelAttributes.Strength);
                Map(p => p.LevelAttributes.Dexterity);
                Map(p => p.LevelAttributes.Intelligence);



            }
        }
    }
}
