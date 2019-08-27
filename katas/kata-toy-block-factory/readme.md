#  Toy Block Factory Kata

There is a factory that makes toy blocks. The blocks come in three different shapes (square, circle and triangle) and in three different colours (red, blue and yellow)

The factory produces things per order. An order consists of a combination of shapes and colors. Below is an example of what an order would look like:  

|          | Red | Blue | Yellow |  
|----------|-----|------|--------|  
| Square   | 1   | -    | 1      |  
| Triangle | -   | 2    | -      |  
| Circle   | -   | 1    | 2      |  

The factory does not keep any stock of blocks, instead blocks are produced per order. For example let's say the factory gets 3 orders in a day, the factory would make each order on it's own.

Your mission is to build a order management system for the factory. The system needs to handle the following:

- Taking orders
- Pricing orders
- Generating a cutting list for an order  
- Generating a painting list for an order
- Viewing all customers

## Pricing of blocks

Blocks have a fixed price which is determine by the shape. We have the following pricing list:

- Square blocks cost $1 
- Triangle blocks cost $2 
- Circle blocks cost $3

There is no additional charge for the colour unless the shape is in red, in which case we charge an additional $1 per shape in red.

## Order details

An order has a
- Customer Name
- Address
- Due Date
- Order Number
- List of the blocks in an order with their respective colors

## Cutting & Painting Department Needs

The factory cutting department and a painting department

Your cutting department has 3 teams, one that cuts squares, one that cuts circles and one that cuts triangles

You have a single painting department that paints all shapes but wants to have shapes grouped by color

# Invoice Report

Name: Mark Pearl
Address: 1 Bob Avenue, Auckland
Due Date: 19 Jan 2019
Order #: 0001

|          | Red | Blue | Yellow |
|----------|-----|------|--------|
| Square   | 1   | -    | 1      |
| Triangle | -   | 2    | -      |
| Circle   | -   | 1    | 2      |

Squares 		2 @ $1 ppi = $2  
Triangles		2 @ $2 ppi = $4  
Circles			3 @ $4 ppi = $12  
Red color surcharge	1 @ $1 ppi = $1  

Total : $19

# Cutting List Report

Name: Mark Pearl
Address: 1 Bob Avenue, Auckland
Due Date: 19 Jan 2019
Order #: 0001

|          | Qty |
|----------|-----|
| Square   | 2   |
| Triangle | 2   |
| Circle   | 3   |

# Painting Report

Name: Mark Pearl
Address: 1 Bob Avenue, Auckland
Due Date: 19 Jan 2019
Order #: 0001

|          | Red | Blue | Yellow |
|----------|-----|------|--------|
| Square   | 1   | -    | 1      |
| Triangle | -   | 2    | -      |
| Circle   | -   | 1    | 2      |

