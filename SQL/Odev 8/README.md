1. test veritabanınızda employee isimli sütun bilgileri id(INTEGER), name VARCHAR(50), birthday DATE, email VARCHAR(100) olan bir tablo oluşturalım.

```SQL
CREATE TABLE employee(
	id SERIAL PRIMARY KEY,
	name varchar(50) NOT NULL,
	email varchar(100) NOT NULL,
	birthday DATE
);
```

2. Oluşturduğumuz employee tablosuna 'Mockaroo' servisini kullanarak 50 adet veri ekleyelim.

```SQL
insert into employee (id, name, email, birthday) values (1, 'Darnall', 'dcleynaert0@mapy.cz', '1937-04-12');
insert into employee (id, name, email, birthday) values (2, 'Nicholle', 'njacobsz1@google.com.au', '1960-04-07');
insert into employee (id, name, email, birthday) values (3, 'Dannel', 'dfeehan2@ycombinator.com', '1964-05-18');
insert into employee (id, name, email, birthday) values (4, 'Morganica', 'mfaveryear3@yale.edu', '1939-07-19');
insert into employee (id, name, email, birthday) values (5, 'Lorita', 'lwolstenholme4@oakley.com', '1912-06-19');
insert into employee (id, name, email, birthday) values (6, 'Deerdre', 'deouzan5@usa.gov', '1962-10-27');
insert into employee (id, name, email, birthday) values (7, 'Feodor', 'floxston6@discovery.com', '1934-08-07');
insert into employee (id, name, email, birthday) values (8, 'Barrie', 'bbrockie7@tamu.edu', '1960-09-22');
insert into employee (id, name, email, birthday) values (9, 'Miner', 'mbraunle8@usda.gov', '1918-07-15');
insert into employee (id, name, email, birthday) values (10, 'Kass', 'kbavage9@list-manage.com', '1947-08-08');
insert into employee (id, name, email, birthday) values (11, 'Milissent', 'mpapaminasa@newsvine.com', '1907-01-08');
insert into employee (id, name, email, birthday) values (12, 'Ellis', 'ederobertob@mapquest.com', '1918-01-19');
insert into employee (id, name, email, birthday) values (13, 'Martino', 'mfowgiesc@sfgate.com', '1940-03-17');
insert into employee (id, name, email, birthday) values (14, 'Fidelio', 'fchecklind@nhs.uk', '1979-02-19');
insert into employee (id, name, email, birthday) values (15, 'Shela', 'sshoute@spiegel.de', '1929-05-09');
insert into employee (id, name, email, birthday) values (16, 'Row', 'rmellowsf@bandcamp.com', '1981-01-04');
insert into employee (id, name, email, birthday) values (17, 'Forester', 'fdroverg@dropbox.com', '1969-06-11');
insert into employee (id, name, email, birthday) values (18, 'Michail', 'mpembleh@wunderground.com', '1941-06-23');
insert into employee (id, name, email, birthday) values (19, 'Salomi', 'slyfei@nyu.edu', '1962-12-02');
insert into employee (id, name, email, birthday) values (20, 'Alina', 'arougheyj@mac.com', '1945-03-23');
insert into employee (id, name, email, birthday) values (21, 'Sonnie', 'scoursk@wikia.com', '1901-03-31');
insert into employee (id, name, email, birthday) values (22, 'Peggi', 'phempell@miitbeian.gov.cn', '1969-04-24');
insert into employee (id, name, email, birthday) values (23, 'Cyndy', 'csturdeym@nymag.com', '1912-02-14');
insert into employee (id, name, email, birthday) values (24, 'Garry', 'ggoodsirn@addthis.com', '1926-12-21');
insert into employee (id, name, email, birthday) values (25, 'Steffen', 'sruggierio@thetimes.co.uk', '1972-11-16');
insert into employee (id, name, email, birthday) values (26, 'Karel', 'kpaulyp@purevolume.com', '1945-12-07');
insert into employee (id, name, email, birthday) values (27, 'Dedra', 'dmcnabq@census.gov', '1902-07-10');
insert into employee (id, name, email, birthday) values (28, 'Anetta', 'avanhaller@nymag.com', '1961-04-08');
insert into employee (id, name, email, birthday) values (29, 'Amery', 'adenziloes@unicef.org', '1958-09-06');
insert into employee (id, name, email, birthday) values (30, 'Amory', 'aallicockt@ebay.com', '1944-04-13');
insert into employee (id, name, email, birthday) values (31, 'Jdavie', 'jcranstounu@apple.com', '1935-11-17');
insert into employee (id, name, email, birthday) values (32, 'Glendon', 'gdrainsv@instagram.com', '1948-04-17');
insert into employee (id, name, email, birthday) values (33, 'Carlen', 'chatwellw@shinystat.com', '1960-07-08');
insert into employee (id, name, email, birthday) values (34, 'Pooh', 'pmcelvinex@dailymail.co.uk', '1935-01-21');
insert into employee (id, name, email, birthday) values (35, 'Pat', 'pvasyunichevy@booking.com', '1987-06-17');
insert into employee (id, name, email, birthday) values (36, 'Malena', 'mtrevithickz@hhs.gov', '1970-06-19');
insert into employee (id, name, email, birthday) values (37, 'Berne', 'blowndesbrough10@github.com', '1912-10-05');
insert into employee (id, name, email, birthday) values (38, 'Jillane', 'jclutten11@cargocollective.com', '1917-03-04');
insert into employee (id, name, email, birthday) values (39, 'Dar', 'dworsalls12@freewebs.com', '1968-11-20');
insert into employee (id, name, email, birthday) values (40, 'Gordy', 'gbrockhouse13@macromedia.com', '1912-06-17');
insert into employee (id, name, email, birthday) values (41, 'Isidora', 'inorthedge14@weebly.com', '1905-05-14');
insert into employee (id, name, email, birthday) values (42, 'Darsey', 'dblazevic15@hugedomains.com', '1923-01-09');
insert into employee (id, name, email, birthday) values (43, 'Austin', 'adurram16@simplemachines.org', '1940-04-03');
insert into employee (id, name, email, birthday) values (44, 'Andra', 'arosenau17@istockphoto.com', '1937-08-30');
insert into employee (id, name, email, birthday) values (45, 'Mohammed', 'mors18@free.fr', '1921-01-28');
insert into employee (id, name, email, birthday) values (46, 'Obadiah', 'oblatherwick19@creativecommons.org', '1994-11-21');
insert into employee (id, name, email, birthday) values (47, 'Gino', 'ghouldey1a@g.co', '1964-11-29');
insert into employee (id, name, email, birthday) values (48, 'Nisse', 'ntimmins1b@mediafire.com', '1915-01-31');
insert into employee (id, name, email, birthday) values (49, 'Dorotea', 'dsherrington1c@narod.ru', '1913-01-16');
insert into employee (id, name, email, birthday) values (50, 'Annissa', 'aworrell1d@timesonline.co.uk', '1999-03-29');
```

3. Sütunların her birine göre diğer sütunları güncelleyecek 5 adet UPDATE işlemi yapalım.

```SQL
UPDATE employee
SET name = 'AAAAA'
WHERE name LIKE 'A%'
RETURNING *;

UPDATE employee
SET email = 'test@gmail.com'
WHERE email LIKE '%@gmail.com'
RETURNING *;

UPDATE employee
SET birthday = '2021-05-07'
WHERE birthday = NULL
RETURNING *;

```

4. Sütunların her birine göre  ilgili satırı silecek 5 adet DELETE işlemi yapalım.

```SQL
DELETE FROM employee
WHERE name = 'AAAAA'
RETURNING *;

DELETE FROM employee
WHERE email = 'test@gmail.com'
RETURNING *;

DELETE FROM employee
WHERE birthday = '2021-05-07'
RETURNING *;
```