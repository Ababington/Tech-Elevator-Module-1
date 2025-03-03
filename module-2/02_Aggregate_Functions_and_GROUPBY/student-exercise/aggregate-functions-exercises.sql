﻿-- The following queries utilize the "world" database.
-- Write queries for the following problems. 
-- Notes:
--   GNP is expressed in units of one million US Dollars
--   The value immediately after the problem statement is the expected number 
--   of rows that should be returned by the query.

-- 1. The name and state plus population of all cities in states that border Ohio 
-- (i.e. cities located in Pennsylvania, West Virginia, Kentucky, Indiana, and 
-- Michigan).  
-- The name and state should be returned as a single column called 
-- name_and_state and should contain values such as ‘Detroit, Michigan’.  
-- The results should be ordered alphabetically by state name and then by city 
-- name. 
-- (19 rows)

select name, district, population from city 
where district IN ('Pennsylvania','West Virginia', 'Kentucky', 'Indiana', 'Michigan') 

-- 2. The name, country code, and region of all countries in Africa.  The name and
-- country code should be returned as a single column named country_and_code 
-- and should contain values such as ‘Angola (AGO)’ 
-- (58 rows)

select name, code, region from country where continent='Africa'

-- 3. The per capita GNP (i.e. GNP multipled by 1000000 then divided by population) of all countries in the 
-- world sorted from highest to lowest. Recall: GNP is express in units of one million US Dollars 
-- (highest per capita GNP in world: 37459.26)

select ((gnp * 1000000)/population) as number from country where population is not null and population != 0 
order by number desc

-- 4. The average life expectancy of countries in South America.
-- (average life expectancy in South America: 70.9461)

select AVG(lifeexpectancy) from country where continent = 'South America'

-- 5. The sum of the population of all cities in California.
-- (total population of all cities in California: 16716706)

select sum(population) from city where district ='California'

-- 6. The sum of the population of all cities in China.
-- (total population of all cities in China: 175953614)

select sum(population) from city where countrycode ='CHN'

-- 7. The maximum population of all countries in the world.
-- (largest country population in world: 1277558000)

select MAX(population) from country 

-- 8. The maximum population of all cities in the world.
-- (largest city population in world: 10500000)

select MAX(population) from city 

-- 9. The maximum population of all cities in Australia.
-- (largest city population in Australia: 3276207)

select MAX(population) from city where countrycode = 'AUS' 

-- 10. The minimum population of all countries in the world.
-- (smallest_country_population in world: 50)

select MIN(population) from country where population is not null and population != 0

-- 11. The average population of cities in the United States.
-- (avgerage city population in USA: 286955.3795)

select AVG(population) from city where countrycode ='USA'

-- 12. The average population of cities in China.
-- (average city population in China: 484720.6997 approx.)

select AVG(population) from city where countrycode ='CHN'

-- 13. The surface area of each continent ordered from highest to lowest.
-- (largest continental surface area: 31881000, "Asia")

select Sum(surfacearea) as surface_area, continent from country 
group by continent
order by surface_area desc 
-- 14. The highest population density (population divided by surface area) of all 
-- countries in the world. 
-- (highest population density in world: 26277.7777)

select (population/surfacearea) as highest_density from country
order by highest_density desc

-- 15. The population density and life expectancy of the top ten countries with the 
-- highest life expectancies in descending order. 
-- (highest life expectancies in world: 83.5, 166.6666, "Andorra")

select top 10 lifeexpectancy, (population/surfacearea) as pop_density, name from country
order by lifeexpectancy desc 

-- 16. The difference between the previous and current GNP of all the countries in 
-- the world ordered by the absolute value of the difference. Display both 
-- difference and absolute difference.
-- (smallest difference: 1.00, 1.00, "Ecuador")

select ABS(gnpold-gnp) as absolute_difference, (gnp - gnpold) as reg_difference ,name from country 
where gnp is not null and gnpold is not null
order by absolute_difference

-- 17. The average population of cities in each country (hint: use city.countrycode)
-- ordered from highest to lowest.
-- (highest avg population: 4017733.0000, "SGP")

select AVG(population) as highest_avg_pop, countrycode as avg_pop
from city
group by countrycode
order by avg_pop desc

-- 18. The count of cities in each state in the USA, ordered by state name.
-- (45 rows)

select district as state_name, count(*) from city where countrycode = 'USA'
group by district
order by state_name 

-- 19. The count of countries on each continent, ordered from highest to lowest.
-- (highest count: 58, "Africa")

select count(*) as country_count, continent from country
group by continent
order by country_count desc
	
-- 20. The count of cities in each country ordered from highest to lowest.
-- (largest number of  cities ib a country: 363, "CHN")

select countrycode as country_name, count(*)as city_count from city
group by countrycode
order by city_count desc

-- 21. The population of the largest city in each country ordered from highest to 
-- lowest.
-- (largest city population in world: 10500000, "IND")

select max(population) as largest_pop, countrycode from city
group by countrycode
order by largest_pop desc

-- 22. The average, minimum, and maximum non-null life expectancy of each continent 
-- ordered from lowest to highest average life expectancy. 
-- (lowest average life expectancy: 52.5719, 37.2, 76.8, "Africa")
select avg(lifeexpectancy) as avg_life, min(lifeexpectancy), max(lifeexpectancy), continent from country
where lifeexpectancy is not null
group by continent
order by avg_life 