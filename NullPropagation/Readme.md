# Null Propagation

With Null Propagation; you can easly check null references and values. It's more readable than if-else statement.

With If-Else Statement:
```sh
var nameSurname =  "Object is null, please send student object";

if(student!=null)
	nameSurname = student.NameSurname;
```

With Ternary Statement:

```sh
var nameSurname = student != null ? student.NameSurname : "Object is null, please send student object";
``` 

With Null Propagation Statement:
```c#
var nameSurname = student?.NameSurname ?? "Object is null, please send student object";
```