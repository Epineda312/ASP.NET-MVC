/*
Challenge Task 1 of 2

In VideoGame.cs create a data model class named VideoGame inside the Treehouse.Models namespace.

    Add a property named Id of type int.
    Add a property named Title of type string.
    Add a property named Description of type string.
    Add a property named Characters of type string[].
    Add a property named Publisher of type string.

Challenge Task 2 of 2
In VideoGame.cs add a read only property named DisplayText of type string.
For the property's return value, return the Title property value followed 
by the Publisher property value in parentheses. For example, given a Title
property value of "Super Mario 64" and a Publisher property value of "Nintendo",
the property's return value should be: Super Mario 64 (Nintendo)

*/ 
namespace Treehouse.Models
{
	public class VideoGame
        {
            public int Id { get; set;}
            public string Title { get; set; }
            public string Description { get; set; }
            public string[] Characters { get; set; }
            public string Publisher { get; set; }
        
   			public string DisplayText
            {
            	get
                {
                	return (Title + " (" + Publisher + ")");
                }
            }
    }
}