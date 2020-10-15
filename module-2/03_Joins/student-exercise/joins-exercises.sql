-- The following queries utilize the "dvdstore" database.

-- 1. All of the films that Nick Stallone has appeared in
-- (30 rows)

select title from film
join film_actor on film.film_id = film_actor.film_id
join actor on film_actor.actor_id = actor.actor_id
where actor.first_name = 'Nick' and actor.last_name =  'Stallone'
order by film.title

-- 2. All of the films that Rita Reynolds has appeared in
-- (20 rows)

select title from film
join film_actor on film.film_id = film_actor.film_id
join actor on film_actor.actor_id = actor.actor_id
where actor.first_name = 'Rita' and actor.last_name =  'Reynolds'
order by film.title

-- 3. All of the films that Judy Dean or River Dean have appeared in
-- (46 rows)
select title from film
join film_actor on film.film_id = film_actor.film_id
join actor on film_actor.actor_id = actor.actor_id
where (actor.first_name = 'Judy' and actor.last_name =  'Dean') or (actor.first_name = 'River' and actor.last_name =  'Dean')
order by film.title

-- 4. All of the the ‘Documentary’ films
-- (68 rows)
select title,name from film
join film_category as fc on fc.film_id = film.film_id
join category on category.category_id = fc.category_id
where category.name = 'Documentary'
order by title


-- 5. All of the ‘Comedy’ films
-- (58 rows)
select title,name from film
join film_category as fc on fc.film_id = film.film_id
join category on category.category_id = fc.category_id
where category.name = 'Comedy'
order by title


-- 6. All of the ‘Children’ films that are rated ‘G’
-- (10 rows)
select title,name, rating from film
join film_category as fc on fc.film_id = film.film_id
join category on category.category_id = fc.category_id
where category.name = 'Children' and rating = 'G'
order by title

-- 7. All of the ‘Family’ films that are rated ‘G’ and are less than 2 hours in length
-- (3 rows)

select title,name, rating, length from film
join film_category as fc on fc.film_id = film.film_id
join category on category.category_id = fc.category_id
where category.name = 'Family' and rating = 'G' and length < 120
order by title

-- 8. All of the films featuring actor Matthew Leigh that are rated ‘G’
-- (9 rows)

select title from film
join film_actor on film.film_id = film_actor.film_id
join actor on film_actor.actor_id = actor.actor_id
where actor.first_name = 'Matthew' and actor.last_name =  'Leigh' and rating = 'G'
order by film.title

-- 9. All of the ‘Sci-Fi’ films released in 2006
-- (61 rows)

select title,name, release_year from film
join film_category as fc on fc.film_id = film.film_id
join category on category.category_id = fc.category_id
where category.name = 'Sci-Fi' and release_year = 2006
order by title


-- 10. All of the ‘Action’ films starring Nick Stallone
-- (2 rows)
select title from film
join film_actor on film.film_id = film_actor.film_id
join film_category as fc on fc.film_id = film.film_id
join category on category.category_id = fc.category_id
join actor on film_actor.actor_id = actor.actor_id
where category.name = 'Action' and actor.first_name = 'Nick' and actor.last_name = 'Stallone'
order by film.title

-- 11. The address of all stores, including street address, city, district, and country
-- (2 rows)

select address.address, city.city, address.district, country.country from store
join address on store.address_id = address.address_id
join city on address.city_id = city.city_id
join country on city.country_id = country.country_id

-- 12. A list of all stores by ID, the store’s street address, and the name of the store’s manager
-- (2 rows)

select store.store_id, address.address, staff.first_name, staff.last_name from store
join staff on store.store_id = staff.store_id
join address on store.address_id = address.address_id
order by store.store_id 

-- 13. The first and last name of the top ten customers ranked by number of rentals 
-- (#1 should be “ELEANOR HUNT” with 46 rentals, #10 should have 39 rentals)

select top 10 customer.first_name, customer.last_name, count(*)as most_rentals from rental 
join customer on rental.customer_id = customer.customer_id
group by customer.first_name, customer.last_name
order by most_rentals desc

-- 14. The first and last name of the top ten customers ranked by dollars spent 
-- (#1 should be “KARL SEAL” with 221.55 spent, #10 should be “ANA BRADLEY” with 174.66 spent)

select top 10 customer.first_name, customer.last_name, sum(amount)as dollars_spent from payment 
join customer on payment.customer_id = customer.customer_id
group by customer.first_name, customer.last_name
order by dollars_spent desc

-- 15. The store ID, street address, total number of rentals, total amount of sales (i.e. payments), and average sale of each store.
-- (NOTE: Keep in mind that an employee may work at multiple stores.)
-- (Store 1 has 7928 total rentals and Store 2 has 8121 total rentals)

select store.store_id, address.address, count(rental.inventory_id)as most_rentals, sum(payment.amount)as dollars_spent, avg(payment.amount)as dollars_avg from store 
join address on store.address_id = address.address_id
join inventory on store.store_id = inventory.store_id
join rental on inventory.inventory_id = rental.inventory_id
join payment on rental.rental_id = payment.rental_id
group by store.store_id, address.address
order by store.store_id 

-- 16. The top ten film titles by number of rentals
-- (#1 should be “BUCKET BROTHERHOOD” with 34 rentals and #10 should have 31 rentals)
select top 10 film.title, count(rental.inventory_id) as mostrentals from film
join inventory on film.film_id = inventory.film_id
join rental on inventory.inventory_id = rental.inventory_id
group by title
order by mostrentals desc

-- 17. The top five film categories by number of rentals 
-- (#1 should be “Sports” with 1179 rentals and #5 should be “Family” with 1096 rentals)

select top 5 name, count(rental.inventory_id) as mostrentals2 from film
join film_category as fc on fc.film_id = film.film_id
join category on category.category_id = fc.category_id
join inventory on film.film_id = inventory.film_id
join rental on inventory.inventory_id = rental.inventory_id
group by category.name 
order by mostrentals2 desc

-- 18. The top five Action film titles by number of rentals 
-- (#1 should have 30 rentals and #5 should have 28 rentals)

select top 5 title, count(rental.inventory_id) as mostrentals3 from film
join film_category as fc on fc.film_id = film.film_id
join category on category.category_id = fc.category_id
join inventory on film.film_id = inventory.film_id
join rental on inventory.inventory_id = rental.inventory_id
where category.name = 'Action'
group by title
order by mostrentals3 desc


-- 19. The top 10 actors ranked by number of rentals of films starring that actor 
-- (#1 should be “GINA DEGENERES” with 753 rentals and #10 should be “SEAN GUINESS” with 599 rentals)

select top 10 actor.first_name,actor.last_name, count(rental.inventory_id) as mostrentals4 from film
join film_actor on film.film_id = film_actor.film_id
join actor on film_actor.actor_id = actor.actor_id
join inventory on film.film_id = inventory.film_id
join rental on inventory.inventory_id = rental.inventory_id
group by actor.actor_id, actor.first_name,actor.last_name
order by mostrentals4 desc

-- 20. The top 5 “Comedy” actors ranked by number of rentals of films in the “Comedy” category starring that actor 
-- (#1 should have 87 rentals and #5 should have 72 rentals)

select top 5 count(rental.inventory_id) as mostrentals5, actor.first_name,actor.last_name from rental
join inventory on inventory.inventory_id = rental.inventory_id
join film on film.film_id = inventory.film_id
join film_category on film_category.film_id = film.film_id
join category on category.category_id = film_category.category_id
join film_actor on film_actor.film_id = film.film_id
join actor on actor.actor_id = film_actor.actor_id
where category.name = 'Comedy'
group by actor.first_name,actor.last_name, actor.actor_id
order by mostrentals5 desc