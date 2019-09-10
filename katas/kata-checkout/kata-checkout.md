# Checkout Kata

Let's implement the code for a checkout system that handles pricing schemes such as “apples cost 50 cents, three apples cost $1.30.”

In a normal supermarket, things are identified using Stock Keeping Units, or SKUs. In our store, we’ll use individual letters of the alphabet (A, B, C, and so on). 

Our goods are priced individually.

~~~
Item   Unit Price  
  -------------
    A     50  
    B     30 
    C     20
    D     15
~~~

Our checkout accepts items in any order, so that if we scan a B, an A, and another B it will be able to give you the total price for one A and two B's

An example of our some of the tests (in ruby) would be:

~~~
co = CheckOut.new(pricing_rules)
co.scan(item)
co.scan(item)
    :    :
price = co.total
~~~

Here’s a set of unit tests for a Ruby implementation. The helper method price lets you specify a sequence of items using a string, calling the checkout’s scan method on each item in turn before finally returning the total price.

~~~
class TestPrice < Test::Unit::TestCase

  def price(goods)
    co = CheckOut.new(RULES)
    goods.split(//).each { |item| co.scan(item) }
    co.total
  end

  def test_totals
    assert_equal(  0, price(""))
    assert_equal( 50, price("A"))
    assert_equal( 80, price("AB"))
    assert_equal(115, price("CDBA"))

    assert_equal(100, price("AA"))
    assert_equal(130, price("AAB"))
  end

  def test_incremental
    co = CheckOut.new(RULES)
    assert_equal(  0, co.total)
    co.scan("A");  assert_equal( 50, co.total)
    co.scan("B");  assert_equal( 80, co.total)
    co.scan("A");  assert_equal(130, co.total)
  end
end
~~~
