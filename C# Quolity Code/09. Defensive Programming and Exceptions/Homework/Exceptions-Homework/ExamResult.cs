using System;

public class ExamResult
{
    private int grade;
    private int minGrade;
    private int maxGrade;
    private string comment;
   
    public int Grade
    {
        get
        {
            return this.grade;
        }
        private set
        {
            if (value > 0)
            {
                this.grade = value;
            }
            else
            {
                throw new ArgumentOutOfRangeException("grade", "ExamResult.Grade cannot be less than zero.");
            }
        }
    }

    public int MinGrade
    {
        get
        {
            return this.minGrade;
        }
        private set
        {
            if (value > 0)
            {
                this.minGrade = value;
            }
            else
            {
                throw new ArgumentOutOfRangeException("MinGrade", "ExamResult.MinGrade cannot be less than zero.");
            }
        }
    }

    public int MaxGrade
    {
        get
        {
            return this.maxGrade;
        }
        private set
        {
            if (value > 0)
            {
                this.maxGrade = value;
            }
            else
            {
                throw new ArgumentOutOfRangeException("MaxGrade", "ExamResult.MaxGrade cannot be less than zero.");
            }
        }
    }
     
    public string Comments
    {  
        get
        {
            return this.comment;
        }
        private set
        {
            if (value != null || value != "")
            {
                this.comment = value;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Comments", "ExamResult.Coment is null or WhiteSpace!");
            }
        } 
    }

    public ExamResult(int grade, int minGrade, int maxGrade, string comments)
    {   
        if(minGrade < maxGrade)
        {
            this.Grade = grade;
            this.MinGrade = minGrade;
            this.MaxGrade = maxGrade;
            this.Comments = comments;
        }
        else
        {
             throw new ArgumentException("maxGrada have to be bigger than minGrade");
        }
    }
}
