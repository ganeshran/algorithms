#special kind of objects
#analogous to enums in .NET
#Symbol literal by colon
#Symbols are globally and immutable. 
#Every next use will use the same instance of the symbol class
#they are more efficient in memory use and performance
#Used as keys for hash
#
puts :abc.to_s.object_id
puts :abc.to_s.object_id
