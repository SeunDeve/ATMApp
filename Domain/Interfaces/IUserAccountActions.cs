using System;
namespace ATMApp.Domain.Interfaces
{
    public interface IUserAccountActions
    {
        void PlaceDeposit();
        void CheckBalance();
        void MakeWithDrawal();
    }
}