﻿using System;
namespace Awacash.Domain.Models.BankOneAccount;

public class TransactionResponseDto
{
    public long Id { get; set; }
    public DateTime CurrentDate { get; set; }
    public bool IsReversed { get; set; }
    public string? ReversalReferenceNo { get; set; }
    public decimal WithdrawableAmount { get; set; }
    public string? UniqueIdentifier { get; set; }
    public string? InstrumentNo { get; set; }
    public DateTime TransactionDate { get; set; }
    public string? TransactionDateString { get; set; }
    public string? ReferenceID { get; set; }
    public string? Narration { get; set; }
    public decimal Amount { get; set; }
    public decimal OpeningBalance { get; set; }
    public decimal Balance { get; set; }
    public string? PostingType { get; set; }
    public string? Debit { get; set; }
    public string? Credit { get; set; }
    public bool IsCardTransation { get; set; }
    public string? AccountNumber { get; set; }
    public string? ServiceCode { get; set; }
    public string? RecordType { get; set; }
    public string? ProductInfo { get; set; }
}

