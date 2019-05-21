using System.ComponentModel.DataAnnotations;
namespace my_vue_starter.Models
{
    public class Persons
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }

    }
}
