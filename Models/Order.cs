using System.ComponentModel.DataAnnotations;

namespace OrdersApp.Models
{
    public class Order
    {
        [Display(Name = "Номер заказа")] public int Id { get; set; }
        [Required] [Display(Name = "Город отправителя:")] public string SenderCity { get; set; }
        [Required] [Display(Name = "Адрес отправителя:")] public string SenderAddress { get; set; }
        [Required] [Display(Name = "Город получателя:")] public string RecieverCity { get; set; }
        [Required] [Display(Name = "Адрес получателя:")] public string RecieverAddress { get; set; }
        [Required] [Display(Name = "Вес груза:")] public double CargoWeight { get; set; }
        [Required] [Display(Name = "Дата заказа:")] public DateTime CreatedAt { get; set; }

    }
}
