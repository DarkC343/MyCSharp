namespace LanguageFeatures.Models
{
    public class Car
    {
        public Car(int? quantity = null)
        {
            Quantity = quantity;
        }
        // auto-implemented property (syntathic sugar): short-crcuiting the full implentation as below
        public string Name { get; set; }
        private string model;
        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        // auto-implemented property initializer: the value will be set if there property is not set explicitly later
        public string Category { get; set; } = "Sport";
        // read-only auto implemented propery: it can be assigned by constrcutors
        public int? Quantity { get; }
        public Car[] GetAllCars()
        {
            var c1 = new Car
            {
                Name = "Peykan",
                Model = "Albaluei",
                Category = "Javanan"
            };
            var c2 = new Car(10000)
            {
                Name = "Saipa",
                Model = "Pride",
                Category = "Motmaen"
            };
            return new Car[] { c1, c2, null };
        }
    }
}