﻿namespace Marketplace.Domain;

public class ClassifiedAd
{
    public readonly Guid Id; // { get; private set; }

    public ClassifiedAd(Guid id, UserId ownerId)
    {
        if (id == default)
            throw new ArgumentException("Identity must be specified", nameof(id));
        if(id == default)
            throw new ArgumentException("Identity must be specified", nameof(ownerId));
        
        Id = id;
        _ownerId = ownerId;
    }

    public void SetTitle(string title) => _title = title;

    public void SetText(string text) => _text = text;

    public void UpdatePrice(decimal price) => _price = price;

    private UserId _ownerId;
    private string _title;
    private string _text;
    private decimal _price;
}