const Double пи = 3.1415;
int k__BackingField;
int set_MyProperty(int value)
{
    k__BackingField = value;
    return k__BackingField;
}
int get_MyProperty()
{
    return k__BackingField;
}

set_MyProperty(15);
get_MyProperty();
System.Console.WriteLine(k__BackingField);
// int MyProperty { get; set; } // не компилируется