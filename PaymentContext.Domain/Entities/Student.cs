﻿using System.Collections;

namespace PaymentContext.Domain.Entities;

public class Student
{
    private readonly IList<Subscription> _subscriptions;
    public Student(string firstName, string lastName, string document, string email, string address)
    {
        FirstName = firstName;
        LastName = lastName;
        Document = document;
        Email = email;
        Address = address;
        _subscriptions = new List<Subscription>();
    }

    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public string Document { get; private set; }
    public string Email { get;  private set; }
    public string Address { get; private set; }
    private IReadOnlyCollection<Subscription> Subscriptions => _subscriptions.ToArray();

    public void AddSubscription(Subscription subscription)
    {
        foreach (var sub in Subscriptions)
        {
            sub.Activate(false);
        }
        _subscriptions.Add(subscription);
    }
}