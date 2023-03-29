USE farmanet;

INSERT PharmacyImages VALUES ('Аптека №1', '/Pharmacies/Аптека №1');
INSERT PharmacyImages VALUES ('Аптека №2', '/Pharmacies/Аптека №2');
INSERT PharmacyImages VALUES ('Аптека №3', '/Pharmacies/Аптека №3');
INSERT PharmacyImages VALUES ('Аптека №4', '/Pharmacies/Аптека №4');
INSERT PharmacyImages VALUES ('Аптека №5', '/Pharmacies/Аптека №5');

INSERT Pharmacies VALUES ('Аптека №1', 'Йошкар-Ола, ул. Красноармейская, дом 40', 'apteka1@mail.ru', 'Очень хорошая аптека, огромные скидки и лучшее обслуживание', 1);
INSERT Pharmacies VALUES ('Аптека №2', 'Йошкар-Ола, ул. Советская, дом 50', 'apteka2@mail.ru', 'Очень хорошая аптека, огромные скидки и лучшее обслуживание', 2);
INSERT Pharmacies VALUES ('Аптека №3', 'Йошкар-Ола, ул. Чкалова, дом 14', 'apteka3@mail.ru', 'Очень хорошая аптека, огромные скидки и лучшее обслуживание', 3);
INSERT Pharmacies VALUES ('Аптека №4', 'Йошкар-Ола, бульвар чавайна, дом 87', 'apteka4@mail.ru', 'Очень хорошая аптека, огромные скидки и лучшее обслуживание', 4);
INSERT Pharmacies VALUES ('Аптека №5', 'Йошкар-Ола, ул. Седова, дом 23', 'apteka5@mail.ru', 'Очень хорошая аптека, огромные скидки и лучшее обслуживание', 5);

INSERT Positions VALUES ('Фармацевт', 200);
INSERT Positions VALUES ('Менеджер', 200);
INSERT Positions VALUES ('Управляющий аптекой', 200);

INSERT WorkerInformationImages VALUES ('Рабочий №1', '/WorkerInfromations/Рабочий №1');
INSERT WorkerInformationImages VALUES ('Рабочий №2', '/WorkerInfromations/Рабочий №2');
INSERT WorkerInformationImages VALUES ('Рабочий №3', '/WorkerInfromations/Рабочий №3');
INSERT WorkerInformationImages VALUES ('Рабочий №4', '/WorkerInfromations/Рабочий №4');
INSERT WorkerInformationImages VALUES ('Рабочий №5', '/WorkerInfromations/Рабочий №5');

INSERT WorkersInformation VALUES (1, 'Максим', 'Прозоров', 'masya.prozorov@mail.ru', '2002-01-21', 6677, 276876, 2, 1);
INSERT WorkersInformation VALUES (1, 'Андрей', 'Салазаров', 'andrey.salazarov@mail.ru', '1990-03-24', 6477, 273276, 3, 2);
INSERT WorkersInformation VALUES (1, 'Григорий', 'Ермаков', 'grig.ermak@mail.ru', '2001-02-22', 4677, 273676, 2, 3);
INSERT WorkersInformation VALUES (1, 'Константин', 'Прохоров', 'konst.proh@mail.ru', '2003-10-11', 6642, 276546, 1, 4);
INSERT WorkersInformation VALUES (1, 'Артем', 'Кельдыбай', 'artyom.keld@mail.ru', '1999-04-13', 6357, 244876, 4, 5);

INSERT WorkerAccounts VALUES ('admin', 'admin', 1, 1);
INSERT WorkerAccounts VALUES ('andre34', 'jhdfds867thdcsh', 1, 1);
INSERT WorkerAccounts VALUES ('grig32', 'jdfjncsdygjsku', 1, 1);
INSERT WorkerAccounts VALUES ('konst21', 'jhdfuycttgsbjc6fg5', 1, 1);
INSERT WorkerAccounts VALUES ('art76', 'jsgd6ff5f68h3j', 1, 1);

INSERT WorkingHours VALUES (1, '2023-03-01', '06:56:01', 'Разложил препараты по аптеке, принял новые препараты.')
INSERT WorkingHours VALUES (1, '2023-03-02', '06:51:11', 'Генеарльная уборка, работа за кассой')
INSERT WorkingHours VALUES (1, '2023-03-03', '07:59:59', 'Принял товар, расфасовал его.')
INSERT WorkingHours VALUES (1, '2023-03-04', '08:52:00', 'Уборка, написал документацию')
INSERT WorkingHours VALUES (1, '2023-03-05', '04:56:10', 'Приезжала инкасация, разбирался с бумагами.')

INSERT Manufacturers VALUES ('ООО "ПрофЛекарство"', 'Россия, Самара, Пушкина, 36');
INSERT Manufacturers VALUES ('ООО "Уроборос"', 'США, Лос-Анджелес, ул. Баха, 12');
INSERT Manufacturers VALUES ('ООО "Umbrella"', 'Россия, Москва, Заводская, 9А');

INSERT MedicationImages VALUES ('Препарат №1', '/Medications/Препарат №1');
INSERT MedicationImages VALUES ('Препарат №2', '/Medications/Препарат №2');
INSERT MedicationImages VALUES ('Препарат №3', '/Medications/Препарат №3');
INSERT MedicationImages VALUES ('Препарат №4', '/Medications/Препарат №4');
INSERT MedicationImages VALUES ('Препарат №5', '/Medications/Препарат №5');
INSERT MedicationImages VALUES ('Препарат №6', '/Medications/Препарат №6');
INSERT MedicationImages VALUES ('Препарат №7', '/Medications/Препарат №7');
INSERT MedicationImages VALUES ('Препарат №8', '/Medications/Препарат №8');
INSERT MedicationImages VALUES ('Препарат №9', '/Medications/Препарат №9');

INSERT MedicationsTypes VALUES ('Гормоны для системного применения');
INSERT MedicationsTypes VALUES ('Дерматологические средства');
INSERT MedicationsTypes VALUES ('Препараты для кровотворения и крови');
INSERT MedicationsTypes VALUES ('Препараты для лечения заболеваний органов чувств');
INSERT MedicationsTypes VALUES ('Препараты для лечения костно-мышечной системы');
INSERT MedicationsTypes VALUES ('Препараты для лечения органов дыхания');
INSERT MedicationsTypes VALUES ('Препараты для мочеполовой системы и половые гормоны');
INSERT MedicationsTypes VALUES ('Препараты для нервной системы');
INSERT MedicationsTypes VALUES ('Препараты для пищеварительного тракта и обмена веществ');
INSERT MedicationsTypes VALUES ('Препараты для сердечно-сосудистой системы');
INSERT MedicationsTypes VALUES ('Противомикробные препараты для системного применения');
INSERT MedicationsTypes VALUES ('Противоопухолевые препараты и имунномодуляторы');
INSERT MedicationsTypes VALUES ('Противопаразитные препараты');
INSERT MedicationsTypes VALUES ('Прочие препараты');
INSERT MedicationsTypes VALUES ('Контрацептивы');

INSERT Medications VALUES ('Амброксол',
'Амброксол назначают в следующих случаях:
Заболевания органов дыхания в острой и хронической форме с образованием вязкого секрета: бронхит, пневмония, бронхиальная астма, ХОБЛ, муковисцидоз, бронхоэктазы, туберкулез, риносинусит, трахеит, ларинготрахеит и другие.
Воспаление носоглотки придаточных пазух носа для разжижения слизи.', 
'амброксола гидрохлорид	30 мг
вспомогательные вещества: лактозы моногидрат (сахар молочный) — 171 мг; крахмал картофельный — 36 мг; кремния диоксид коллоидный (аэросил) — 1,8 мг; магния стеарат — 1,2 мг',
'Амброксол нельзя принимать при следующих состояниях:
Язвенная болезнь желудка и 12-перстной кишки в фазе обострения.
Нарушение подвижности бронхов и формирование секрета в больших количествах.
Легочное кровотечение.
Нарушение функции почек и печени.
Эпилепсия.
Беременность до 12 недель.
Непереносимость компонентов лекарства: например, лактозы (таблетки), сорбита (сироп).', 
'Дозировка амброксола взрослым и детям назначается индивидуально в зависимости от возраста, либо исходя из расчета 1–1,5 мг действующего вещества в сутки на 1 кг массы тела. В среднем, чтобы получить лечебный эффект препарата, его принимают 2–3 раза в день, тогда как капсулы пролонгированного действия можно пить только один раз в сутки.
Принимать препарат внутрь как правило рекомендуется во время еды или после еды. ',
6, 
1);

INSERT Medications VALUES ('Фенибут',
'C осторожностью применять при эрозивно-язвенных поражениях ЖКТ, печеночной недостаточности.При длительном применении необходимо контролировать показатели функции печени и картину периферической крови.Малоэффективен при выраженных явлениях укачивания (в т.ч. неукротимая рвота, головокружение).','Микрокристаллическая целлюлоза 220,0 мг Кремния диоксид коллоидный 25,0 мг Карбоксиметилкрахмал натрия 25,0 мгКальция стеарат 5,0 мг',
'Ноотропное средство, представляет собой гамма-амино-бета-фенилмасляной кислоты гидрохлорид. Облегчает GABA-опосредованную передачу нервных импульсов в ЦНС (прямое воздействие на GABA-рецепторы), оказывает также транквилизирующее, психостимулирующее, антиагрегантное и антиоксидантное действие.', 
'Абсорбция высокая, хорошо проникает во все ткани организма и через ГЭБ (в ткани мозга проникает около 0.1% введенной дозы препарата, причем у лиц молодого и пожилого возраста в значительно большей степени). Равномерно распределяется в печени и почках. Метаболизируется в печени - 80-95%, метаболиты фармакологически неактивны. Не кумулирует.',
8, 
2);

INSERT MedicationWithManufacturers VALUES(1, 2);
INSERT MedicationWithManufacturers VALUES(2, 2);

INSERT Sales VALUES (1, 1, 5, 100);
INSERT Sales VALUES (2, 1, 2, 150);
INSERT Sales VALUES (1, 1, 1, 150);

INSERT Suppliers VALUES ('ФармаПривоз', 7533746);
INSERT Suppliers VALUES ('ФармЗмей', 7464657);
INSERT Suppliers VALUES ('ФармаДоставка', 8758749);

INSERT Imports VALUES (1875562, '2023-02-21', 600, 1, 1);
INSERT Imports VALUES (1875563, '2023-02-22', 800, 1, 1);
INSERT Imports VALUES (1875564, '2023-02-23', 750, 1, 1);

INSERT PharmacyWithMedications VALUES (1, 1, 100, 20);
INSERT PharmacyWithMedications VALUES (2, 1, 150, 30);
INSERT PharmacyWithMedications VALUES (1, 2, 100, 20);
INSERT PharmacyWithMedications VALUES (2, 2, 150, 30);
INSERT PharmacyWithMedications VALUES (1, 3, 100, 20);
INSERT PharmacyWithMedications VALUES (2, 4, 150, 30);

INSERT WriteDowns VALUES (1, 1, 10);
INSERT WriteDowns VALUES (2, 2, 5);
INSERT WriteDowns VALUES (3, 1, 3);

SELECT *
FROM Medications;