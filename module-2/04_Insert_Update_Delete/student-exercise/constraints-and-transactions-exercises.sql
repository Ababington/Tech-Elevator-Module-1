-- Write queries to return the following:
-- The following changes are applied to the "dvdstore" database.**

-- 1. Add actors, Hampton Avenue, and Lisa Byway to the actor table.

insert into actor (first_name, last_name)
values ( 'Hampton', 'Avenue')
insert into actor (first_name, last_name)
values ('Lisa', 'Byway')

-- 2. Add "Euclidean PI", "The epic story of Euclid as a pizza delivery boy in
-- ancient Greece", to the film table. The movie was released in 2008 in English.
-- Since its an epic, the run length is 3hrs and 18mins. There are no special
-- features, the film speaks for itself, and doesn't need any gimmicks.

insert into film (title, description, release_year, language_id, original_language_id,length)
values ('Euclidean PI', 'The epic story of Euclid as a pizza delivery boy in ancient Greece', 2008, 1, null,198)
select * from film order by film_id desc

-- 3. Hampton Avenue plays Euclid, while Lisa Byway plays his slightly
-- overprotective mother, in the film, "Euclidean PI". Add them to the film.

insert into film_actor (actor_id, film_id)
values ((select film_id from film where title ='Euclidean PI'),
(select actor_id from actor where first_name = 'Hampton' and last_name = 'Avenue' ))
insert into film_actor (actor_id, film_id)
values  ((select film_id from film where title ='Euclidean PI'),
(select actor_id from actor where first_name = 'Lisa' and last_name = 'Byway' ));

select * from film_actor order by film_id desc

-- 4. Add Mathmagical to the category table.

insert into category
values ('Mathmagical')

select * from category

-- 5. Assign the Mathmagical category to the following films, "Euclidean PI",
-- "EGG IGBY", "KARATE MOON", "RANDOM GO", and "YOUNG LANGUAGE"


update film_category set category_id = (select category_id from category where name = 'Mathmagical')
where film_id in (select film_id from film where title in ('Euclidean PI', 'EGG IGBY', 'KARATE MOON', 'RANDOM GO', 'YOUNG LANGUAGE'));

select * from film_category
order by category_id

-- 6. Mathmagical films always have a "G" rating, adjust all Mathmagical films
-- accordingly.
-- (5 rows affected)


update film set rating = 'G' 
where film_id in (select film_id from category where name = 'Mathmagical')

-- 7. Add a copy of "Euclidean PI" to all the stores.


insert into inventory(store_id, film_id) 
select store_id,(select film_id from film where title = 'Euclidean PI') from store; 
select * from inventory
order by film_id desc


-- 8. The Feds have stepped in and have impounded all copies of the pirated film,
-- "Euclidean PI". The film has been seized from all stores, and needs to be
-- deleted from the film table. Delete "Euclidean PI" from the film table.
-- (Did it succeed? Why?)
-- <YOUR ANSWER HERE>
delete film where title = 'Euclidean PI'
--It fails because it has keys located in other tables as well.

-- 9. Delete Mathmagical from the category table.
-- (Did it succeed? Why?)
-- <YOUR ANSWER HERE>


delete category where name = 'Mathmagical'
-- It fails because it has keys in film_category as well

-- 10. Delete all links to Mathmagical in the film_category tale.
-- (Did it succeed? Why?)
-- <YOUR ANSWER HERE>


delete film_category where category_id in (select category_id from category where name ='Mathmagical');
--Yes, this succeeds because film_category was the last remaining key to hold category_id of (Mathmagical)

-- 11. Retry deleting Mathmagical from the category table, followed by retrying
-- to delete "Euclidean PI".
-- (Did either deletes succeed? Why?)
-- <YOUR ANSWER HERE>

delete from category where name = 'Euclidean PI'

--This fails because 1002 is still in the film_actor table

-- 12. Check database metadata to determine all constraints of the film id, and
-- describe any remaining adjustments needed before the film "Euclidean PI" can
-- be removed from the film table.
select * from INFORMATION_SCHEMA.REFERENTIAL_CONSTRAINTS
where CONSTRAINT_NAME like '%film%'

-- you would have to remove any area that references 'Euclidean PI' as its Parent from the film_actor & inventory table as well
