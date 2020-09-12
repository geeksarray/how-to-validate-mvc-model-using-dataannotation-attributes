# How to validate mvc model using dataannotation attributes
This tutorial helps you to understand how you can use DataAnnotation attributes for validation of model data.

DataAnnotation namespace
All DataAnnotation attributes are included in System.ComponentModel.DataAnnotations namespace. Various DataAnnotation attributes give you a simple way to perform validation on model data. These attributes are helpful for common validation patterns like Required, Range, StringLength, etc. It can perform validation on both the client and server side.

## Files

1. **[Customer Model](https://github.com/geeksarray/how-to-validate-mvc-model-using-dataannotation-attributes/blob/master/FirstMVC/FirstMVC/Models/Customer.cs)** - with Data 
   Annotation attributes applied on customer properties.

1. **[Home Controller](https://github.com/geeksarray/how-to-validate-mvc-model-using-dataannotation-attributes/blob/master/FirstMVC/FirstMVC/Controllers/HomeController.cs)** - having Customer models used with Data Annotation validation.

Below image shows validation erros triggered by Data Annotations 

![Data Annotations Validations](http://dotnetmentors.com/Images/asp-net-mvc-dataannotations-validation-attribute.png)

For more details visit - https://geeksarray.com/blog/how-to-validate-mvc-model-using-dataannotation-attributes
