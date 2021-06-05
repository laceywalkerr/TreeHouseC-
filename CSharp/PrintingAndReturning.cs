Return and print are statements, not functions

Print just shows the human user a string representing what is going on inside the computer.
The computer cannot make use of that printing.
Return is how a function gives back a value.
This value is often unseen by the human user, but it can be used by the computer in further functions.

return is the main way that a function returns a value.All functions will
return a value,
    and
if there is no
return statement(or yield but don’ t worry about that yet), it will
return None.
The value that is returned by a function can then be further used as an argument passed to another function,
stored as a variable, or just printed
for the benefit of the human user.