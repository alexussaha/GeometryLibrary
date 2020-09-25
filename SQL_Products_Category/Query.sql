select products.name, category.name from Products 
left join ProductCategory on products.id = productcategory.products_id 
inner join Category on category.id = productcategory.category_id