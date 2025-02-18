# C# NullReferenceException: Uninitialized Property Access

This repository demonstrates a common C# error: a `NullReferenceException` caused by accessing an uninitialized property.  The `bug.cs` file shows the problematic code, while `bugSolution.cs` provides a solution.

## Problem

In the `ExampleClass`, the `MyMethod` attempts to use the `MyProperty` before it's been given a value. If `MyProperty` remains null (its default state), this operation will throw a `NullReferenceException`.

## Solution

The `bugSolution.cs` shows two ways to avoid this:

1. **Initialization in the constructor:**  Explicitly set a default value for `MyProperty` in the class constructor.
2. **Null check:** Before using `MyProperty`, check if it's null and handle it accordingly (e.g., provide an alternative value or avoid the operation).