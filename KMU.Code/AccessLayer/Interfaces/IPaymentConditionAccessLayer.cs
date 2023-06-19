﻿using KMU.Data.Model;

namespace KMU.Code.AccessLayer.Interfaces;

internal interface IPaymentConditionAccessLayer
{
    List<PaymentCondition> GetPaymentConditions();

    void AddPaymentCondition(PaymentCondition condition);

    void EditPaymentCondition(PaymentCondition condition);

    void RemovePaymentCondition(int id);

    PaymentCondition GetPaymentConditionById(int id);
}