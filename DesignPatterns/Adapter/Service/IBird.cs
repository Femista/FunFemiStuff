﻿namespace Adapter.Service
{
    public interface IBird
    {
        // birds implement Bird interface that allows 
        // them to fly and make sounds adaptee interface 
        void fly();
        void makeSound();
    }
}