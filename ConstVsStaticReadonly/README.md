# Difference betwen *static readonly* and *const* #

##Intro

There is an interesting question here on [Stackoverflow](http://stackoverflow.com/questions/755685/c-static-readonly-vs-const/756010#756010 "Stackoverflow"). 

Michael Stum wrote [an useful article](http://www.stum.de/2009/01/14/const-strings-a-very-convenient-way-to-shoot-yourself-in-the-foot/) about the main difference, and my code is to confirm it ! As of 2014, it's still happening in .NET 4.5.

##How to verify

1. Compile the StringProducer.soln and copy the `StringProducer\bin\Debug\StringProducer.dll` to folder `StringConsumer\Consumer\bin`.

2. Compile the StringConsumer.soln and run the `\StringConsumer\bin\Debug\Consumer.exe`, you'll see the console output similar to:

    `ConstString = 1`

    `StaticReadonlyStringValue = 1`

3. Modified the 2 properties of `StringProducer\Producer.cs` file to any value you want. Now **compile ONLY the StringProducer.soln** to reproduce the `StringProducer\bin\Debug\StringProducer.dll`.

4. Repeat step 1 and step 2, observe the result in console:
    
    `ConstString = 1` **(no change at all)**

    `StaticReadonlyStringValue = <new value>` **(value changed)**


##Conclusion
Advised by Michael Stum: use static readonly if the consumer is in a different assembly. **`const`** value is set only at compile while **`static readonly`** is updated at runtime, hence it is safer.