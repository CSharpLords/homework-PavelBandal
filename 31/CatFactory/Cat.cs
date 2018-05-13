using System;

namespace CatFactory {
	class Cat {
		public string name;
		public double age;
		public double weight;
		public double strenght;
        int score = 0;
        public Cat (string name, double age, double weight, double strenght)
        {
            this.name = name;
            this.age = age;
            this.weight = weight;
            this.strenght = strenght;
        }
        public string Fight(Cat kotic)
        {
            score = 0;
            kotic.score = 0;
            if (age > kotic.age)
            {
                score++;
            }
            else
            {
                kotic.score++;
            }
            if (weight > kotic.weight)
            {
                score++;
            }
            else
            {
                kotic.score++;
            }
            if (strenght > kotic.strenght)
            {
                score++;
            }
            else
            {
                kotic.score++;
            }
            if (kotic.score > score)
            {
                return kotic.name;
            }
            else
            {
                return name;
            }
        }
    }
}
