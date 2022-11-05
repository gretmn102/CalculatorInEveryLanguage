puts "Input your first number\n"
firstnum = gets.to_i

puts "Input your second number\n"
secondnum = gets.to_i

puts "Input your desired operation\n"
operation = gets.chomp

puts "\n"

if operation == "+"
  puts firstnum + secondnum
end

if operation == "-"
  puts firstnum - secondnum
end

if operation == "*"
  puts firstnum * secondnum
end

if operation == "/"
  puts firstnum / secondnum
end
