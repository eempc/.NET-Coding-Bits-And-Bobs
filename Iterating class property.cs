using System.Reflection;

Box myBox = new Box(3,4,5); //Where x, y, z

//Type type = typeof(Box);
//FieldInfo[] fields = type.GetFields();

foreach (var field in myBox.GetType().GetFields()) {
  Console.Writeline(field.Name + ": " + field.GetValue(myBox).ToString());
}
