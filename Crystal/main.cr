puts "Input your first number number"
N1 = gets.try(&.to_i) || 0
puts "Input your second number"
N2 = gets.try(&.to_i) || 0
SUM = N1 + N2 

def main 
  puts "#{SUM}"
end 

main
