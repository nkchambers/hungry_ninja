namespace hungry_ninja
{
    class Food
    {
    
    //-------------------------Define Food Class Fields (Name, Calories, IsSpicy, IsSweet)------------------------------
        public string Name;
        public int Calories;
        
        //Foods can be Spicy and/or Sweet
        public bool IsSpicy;
        public bool IsSweet;


    //----------------Default Constructor lets you construct empty Food object------------
        public Food() {}
        

    //----------------Add constructor that takes all four parameteres (Name, Calories, IsSpicy, IsSweet)-------------------
        public Food(string name, int calories, bool isspicy, bool issweet)
        {
            Name = name;
            Calories = calories;
            IsSpicy = isspicy;
            IsSweet = issweet;

        }

    


    //----------------------------------Public Override to String----------------------------------
        public override string ToString()
        { 
            return @$"
    Name:           {Name}
    Calories:       {Calories}
    IsSpicy:        {IsSpicy}
    IsSweet:        {IsSweet}
            ";
        }



    }
}