enum Sex
{
    Male,
    Female
};

class MainClass
{
  public void CreateHumman(int age)
  {
      Human currentHumman = new Humman();
      currentHumman.Age = age;

      if (age % 2 == 0)
      {
          currentHumman.Name = "Brother";
          currentHumman.Sex = Sex.Male;
      }
      else
      {
          currentHumman.Name = "Cat";
          currentHumman.Sex = Sex.Female;
      }
  }
}

class Humman
{
    public Sex sex { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
}