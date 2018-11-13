# XmlToClass
An improved version of converting a Xml document to a c# class.

Improved:
* The created class has auto properties (Not so verbose)
* All values read from the xml file are default values in the class
* Allows renaming properties without changing the element and attribute names. The xml names are specified by the special xml attributes
* New CreatedObject will also create an instance of all subclasses
