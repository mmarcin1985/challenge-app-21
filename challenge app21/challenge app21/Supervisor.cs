﻿
//using static challenge_app21.EmployeeBase;

//namespace challenge_app21
//{
//    public class Supervisor : EmployeeBase
//    {
//        private List<float> score = new List<float>();
//        public override event GradeAddedDelegate GradeAdded;

//        public Supervisor(string name, string surname, string sex, int age): base(name, surname, sex, age)
//        {
//        }

//        public string Name { get; private set; }
//        public string Surname { get; private set; }
//        public string Sex { get; private set; }
//        public int Age { get; private set; }


//        public override void AddScoreAward(float rate)
//        {
//            if (rate >= 0 && rate <= 100)
//            {
//                this.score.Add(rate);
//            }
//            else
//            {
//                throw new Exception($" {rate} out of range please input number from range  7-100 or ''school rate'' 6,5,4,3,2,1 with optional +/-  or q/q to quit\"");
//            }
//        }

//        //public override void AddScoreAward(string rate)
//        //{
//        //    {
//        //        switch (rate)
//        //        {
//        //            case "6":
//        //                this.AddScoreAward(100);
//        //                break;
//        //            case "6-":
//        //            case "-6":
//        //                this.AddScoreAward(95);
//        //                break;
//        //            case "5+":
//        //            case "+5":
//        //                this.AddScoreAward(85);
//        //                break;
//        //            case "5":
//        //                this.AddScoreAward(80);
//        //                break;
//        //            case "5-":
//        //            case "-5":
//        //                this.AddScoreAward(75);
//        //                break;
//        //            case "4+":
//        //            case "+4":
//        //                this.AddScoreAward(65);
//        //                break;
//        //            case "4":
//        //                this.AddScoreAward(60);
//        //                break;
//        //            case "4-":
//        //            case "-4":
//        //                this.AddScoreAward(55);
//        //                break;
//        //            case "3+":
//        //            case "+3":
//        //                this.AddScoreAward(45);
//        //                break;
//        //            case "3":
//        //                this.AddScoreAward(40);
//        //                break;
//        //            case "3-":
//        //            case "-3":
//        //                this.AddScoreAward(35);
//        //                break;
//        //            case "2+":
//        //            case "+2":
//        //                this.AddScoreAward(25);
//        //                break;
//        //            case "2":
//        //                this.AddScoreAward(20);
//        //                break;
//        //            case "2-":
//        //            case "-2":
//        //                this.AddScoreAward(15);
//        //                break;
//        //            case "1+":
//        //            case "+1":
//        //                this.AddScoreAward(5);
//        //                break;
//        //            case "1":
//        //                this.AddScoreAward(0);
//        //                break;
//        //            default:
//        //                float.TryParse(rate, out float results);
//        //                this.AddScoreAward(results);
//        //                break;
//        //        }
//        //    }
//        //}

//        //public void AddScoreAward(char rate)
//        //{
//        //    string rate1 = rate.ToString();
//        //    this.AddScoreAward(rate1);
//        //}

//        //public void AddScoreAward(double rate)
//        //{
//        //    float rate1 = (float)rate;
//        //    this.AddScoreAward(rate1);
//        //}


//        public override Statistics GetStatistic()
//        {
//            var statistics = new Statistics();
//            if (this.score.Count > 0)
//            {
//                foreach (var score in this.score)
//                {
//                    statistics.Addgrade(score);
//                }
//                return statistics;
//            }

//            else
//            {
//                throw new Exception("no correct rate added, statistics can not be generated");
//            }
//        }
//    }
//}

