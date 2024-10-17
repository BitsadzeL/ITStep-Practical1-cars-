using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practical
{
    //Make,     Model,      Cylinder,       Engine,             Drive,          Transmission,    City,       Combined,   Highway
    //Ferrari,  Testarossa,    12,             4.9,        Rear-Wheel Drive,    Manual 5-spd,       9,         11,       14
    public class Car
    {
        public string Make { get; set; }
        public string Model{ get; set; }
        public int Cylinder { get; set; }
        public double Engine { get; set; }
        public string Drive{ get; set; }
        public string Transmission { get; set; }
        public double City { get; set; }
        public double Combined { get; set; }
        public double Highway { get; set; }

        public Car(string make, string model, int cylinder, double engine, string drive, 
            string transmission, double city,double combined, double highway) {
            Make = make;
            Model = model;
            Cylinder = cylinder;
            Engine = engine;
            Drive = drive;
            Transmission = transmission;
            City = city;
            Combined = combined;
            Highway = highway;
        }

        public override string ToString() {
            return $"{Make} {Model} {Cylinder} {Engine} {Drive} {Transmission} {City} {Combined} {Highway}";        
        }


        public static List<Car> parse(string[] input)
        {
            List<Car> result = new List<Car>();
            for (int i = 1; i < input.Length; i++)
            {
                string[] data = input[i].Split(',');
                string make = data[0];
                string model = data[1];
                int cylinder = Convert.ToInt32(data[2]);
                double engine = Convert.ToDouble(data[3]);
                string drive = data[4];
                string transmission = data[5];
                double city = Convert.ToDouble(data[6]);
                double combined = Convert.ToDouble(data[7]);
                double highway = Convert.ToDouble(data[8]);
                Car carobj = new Car(make, model, cylinder, engine, drive, transmission, city, combined, highway);
                result.Add(carobj);

            }
            return result;
        }


        public static List<Car> GetAllMercedes(List<Car> data)
        {
            List<Car> mercedeses= new List<Car>();
            for (int i = 0; i < data.Count; i++)
            {
                if (data[i].Make.Contains("Mercedes"))
                {
                    mercedeses.Add(data[i]);
                }
            }
            return mercedeses;

        }


        public static List<Car> Get10EconomyCars(List<Car> data) 
        { 
            List<Car> economyCars= new List<Car>();

            for (int i = 0; i < data.Count - 1 - 1; i++)
            {
                for (int j = 0; j < data.Count - 1 - i - 1; j++)
                {
                    
                    if (data[j].Combined < data[j + 1].Combined)
                    {
                        
                        Car temp = data[j];
                        data[j] = data[j + 1];
                        data[j + 1] = temp;
                    }
                }
            }

            for (int i = 0; i < 10; i++)
            {
                economyCars.Add(data[i]);
            }
            return economyCars;
        
        }




    }
}
