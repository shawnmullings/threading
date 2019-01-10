# Threading Synchronization

## Instructions

This program may be written in the language of your choosing, but must be written in a language
that supports multithreading. This program should output all of the positive integers from 1 to 100. Internally, the program
must use two threads; one thread that prints odd numbers and another thread that prints even numbers. Furthermore,
these two threads must be synchronized such that the output appears in correct numerical order. The program may contain
multiple methods, and if using an OO language, the program should be contained within a single class or object.

- The program should be designed so that it begins execution when invoked through whichever mechanism is most common for the implementation language.
- Print out all positive integers from 1 to 100, inclusive and in order.
- Print messages to standard output, matching the Sample Output below.
- Upon starting, create two separate threads, one thread that counts odd numbers only and one thread that counts even numbers only.
- Through the use of synchronization blocks, notifications, semaphores, or other similar mechanisms, coordinate the threads such that the combined output from both threads appears in numerical order.
- Include a thread identifier in the output, indicating the source thread that generated the message.
- Execute as fast as possible, avoiding the use of any sleep or timed waits.

Sample Output

```
Thread 1: The number is ‘1’
Thread 2: The number is ‘2’
Thread 1: The number is ‘3’
```

### Dependencies

- .NET Framework 4.7 >
- Microsoft Visual Studio or VS Code

### Installation

Download git repo then open 'Threading.sln' file. Run!
