﻿namespace PaymentContext.Domain.Entities;

public abstract class Payment
{
    public string Number { get; set; }
    public DateTime PaidDate { get; set; }
    public DateTime ExpiredDate { get; set; }
    public decimal Total { get; set; }
    public decimal TotalPaid { get; set; }
    public string Payer { get; set; }
    public string Document { get; set; }
    public string Address { get; set; }
}

public class BoletoPayment : Payment
{
    public string BarCode { get; set; }
    public string BoletoNumber { get; set; }
}

public class CreditCardPayment : Payment
{
    public int CardHolderName { get; set; }
    public int CardNumber { get; set; }
    public int LastTransactionNumber { get; set; }
}

public class PayPalPayment : Payment
{
    public int TransactionCode { get; set; }
}