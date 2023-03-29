USE farmanet;

INSERT PharmacyImages VALUES ('������ �1', '/Pharmacies/������ �1');
INSERT PharmacyImages VALUES ('������ �2', '/Pharmacies/������ �2');
INSERT PharmacyImages VALUES ('������ �3', '/Pharmacies/������ �3');
INSERT PharmacyImages VALUES ('������ �4', '/Pharmacies/������ �4');
INSERT PharmacyImages VALUES ('������ �5', '/Pharmacies/������ �5');

INSERT Pharmacies VALUES ('������ �1', '������-���, ��. ���������������, ��� 40', 'apteka1@mail.ru', '����� ������� ������, �������� ������ � ������ ������������', 1);
INSERT Pharmacies VALUES ('������ �2', '������-���, ��. ���������, ��� 50', 'apteka2@mail.ru', '����� ������� ������, �������� ������ � ������ ������������', 2);
INSERT Pharmacies VALUES ('������ �3', '������-���, ��. �������, ��� 14', 'apteka3@mail.ru', '����� ������� ������, �������� ������ � ������ ������������', 3);
INSERT Pharmacies VALUES ('������ �4', '������-���, ������� �������, ��� 87', 'apteka4@mail.ru', '����� ������� ������, �������� ������ � ������ ������������', 4);
INSERT Pharmacies VALUES ('������ �5', '������-���, ��. ������, ��� 23', 'apteka5@mail.ru', '����� ������� ������, �������� ������ � ������ ������������', 5);

INSERT Positions VALUES ('���������', 200);
INSERT Positions VALUES ('��������', 200);
INSERT Positions VALUES ('����������� �������', 200);

INSERT WorkerInformationImages VALUES ('������� �1', '/WorkerInfromations/������� �1');
INSERT WorkerInformationImages VALUES ('������� �2', '/WorkerInfromations/������� �2');
INSERT WorkerInformationImages VALUES ('������� �3', '/WorkerInfromations/������� �3');
INSERT WorkerInformationImages VALUES ('������� �4', '/WorkerInfromations/������� �4');
INSERT WorkerInformationImages VALUES ('������� �5', '/WorkerInfromations/������� �5');

INSERT WorkersInformation VALUES (1, '������', '��������', 'masya.prozorov@mail.ru', '2002-01-21', 6677, 276876, 2, 1);
INSERT WorkersInformation VALUES (1, '������', '���������', 'andrey.salazarov@mail.ru', '1990-03-24', 6477, 273276, 3, 2);
INSERT WorkersInformation VALUES (1, '��������', '�������', 'grig.ermak@mail.ru', '2001-02-22', 4677, 273676, 2, 3);
INSERT WorkersInformation VALUES (1, '����������', '��������', 'konst.proh@mail.ru', '2003-10-11', 6642, 276546, 1, 4);
INSERT WorkersInformation VALUES (1, '�����', '���������', 'artyom.keld@mail.ru', '1999-04-13', 6357, 244876, 4, 5);

INSERT WorkerAccounts VALUES ('admin', 'admin', 1, 1);
INSERT WorkerAccounts VALUES ('andre34', 'jhdfds867thdcsh', 1, 1);
INSERT WorkerAccounts VALUES ('grig32', 'jdfjncsdygjsku', 1, 1);
INSERT WorkerAccounts VALUES ('konst21', 'jhdfuycttgsbjc6fg5', 1, 1);
INSERT WorkerAccounts VALUES ('art76', 'jsgd6ff5f68h3j', 1, 1);

INSERT WorkingHours VALUES (1, '2023-03-01', '06:56:01', '�������� ��������� �� ������, ������ ����� ���������.')
INSERT WorkingHours VALUES (1, '2023-03-02', '06:51:11', '����������� ������, ������ �� ������')
INSERT WorkingHours VALUES (1, '2023-03-03', '07:59:59', '������ �����, ���������� ���.')
INSERT WorkingHours VALUES (1, '2023-03-04', '08:52:00', '������, ������� ������������')
INSERT WorkingHours VALUES (1, '2023-03-05', '04:56:10', '��������� ���������, ���������� � ��������.')

INSERT Manufacturers VALUES ('��� "�������������"', '������, ������, �������, 36');
INSERT Manufacturers VALUES ('��� "��������"', '���, ���-��������, ��. ����, 12');
INSERT Manufacturers VALUES ('��� "Umbrella"', '������, ������, ���������, 9�');

INSERT MedicationImages VALUES ('�������� �1', '/Medications/�������� �1');
INSERT MedicationImages VALUES ('�������� �2', '/Medications/�������� �2');
INSERT MedicationImages VALUES ('�������� �3', '/Medications/�������� �3');
INSERT MedicationImages VALUES ('�������� �4', '/Medications/�������� �4');
INSERT MedicationImages VALUES ('�������� �5', '/Medications/�������� �5');
INSERT MedicationImages VALUES ('�������� �6', '/Medications/�������� �6');
INSERT MedicationImages VALUES ('�������� �7', '/Medications/�������� �7');
INSERT MedicationImages VALUES ('�������� �8', '/Medications/�������� �8');
INSERT MedicationImages VALUES ('�������� �9', '/Medications/�������� �9');

INSERT MedicationsTypes VALUES ('������� ��� ���������� ����������');
INSERT MedicationsTypes VALUES ('����������������� ��������');
INSERT MedicationsTypes VALUES ('��������� ��� ������������� � �����');
INSERT MedicationsTypes VALUES ('��������� ��� ������� ����������� ������� ������');
INSERT MedicationsTypes VALUES ('��������� ��� ������� ������-�������� �������');
INSERT MedicationsTypes VALUES ('��������� ��� ������� ������� �������');
INSERT MedicationsTypes VALUES ('��������� ��� ����������� ������� � ������� �������');
INSERT MedicationsTypes VALUES ('��������� ��� ������� �������');
INSERT MedicationsTypes VALUES ('��������� ��� ���������������� ������ � ������ �������');
INSERT MedicationsTypes VALUES ('��������� ��� ��������-���������� �������');
INSERT MedicationsTypes VALUES ('���������������� ��������� ��� ���������� ����������');
INSERT MedicationsTypes VALUES ('����������������� ��������� � ����������������');
INSERT MedicationsTypes VALUES ('����������������� ���������');
INSERT MedicationsTypes VALUES ('������ ���������');
INSERT MedicationsTypes VALUES ('�������������');

INSERT Medications VALUES ('���������',
'��������� ��������� � ��������� �������:
����������� ������� ������� � ������ � ����������� ����� � ������������ ������� �������: �������, ���������, ������������ �����, ����, ������������, ������������, ����������, �����������, �������, �������������� � ������.
���������� ���������� ����������� ����� ���� ��� ���������� �����.', 
'���������� �����������	30 ��
��������������� ��������: ������� ���������� (����� ��������) � 171 ��; ������� ������������ � 36 ��; ������� ������� ���������� (�������) � 1,8 ��; ������ ������� � 1,2 ��',
'��������� ������ ��������� ��� ��������� ����������:
�������� ������� ������� � 12-�������� ����� � ���� ����������.
��������� ����������� ������� � ������������ ������� � ������� �����������.
�������� ������������.
��������� ������� ����� � ������.
���������.
������������ �� 12 ������.
��������������� ����������� ���������: ��������, ������� (��������), ������� (�����).', 
'��������� ���������� �������� � ����� ����������� ������������� � ����������� �� ��������, ���� ������ �� ������� 1�1,5 �� ������������ �������� � ����� �� 1 �� ����� ����. � �������, ����� �������� �������� ������ ���������, ��� ��������� 2�3 ���� � ����, ����� ��� ������� ����������������� �������� ����� ���� ������ ���� ��� � �����.
��������� �������� ������ ��� ������� ������������� �� ����� ��� ��� ����� ���. ',
6, 
1);

INSERT Medications VALUES ('�������',
'C ������������� ��������� ��� ��������-�������� ���������� ���, ���������� ���������������.��� ���������� ���������� ���������� �������������� ���������� ������� ������ � ������� �������������� �����.�������������� ��� ���������� �������� ���������� (� �.�. ����������� �����, ��������������).','�������������������� ��������� 220,0 �� ������� ������� ���������� 25,0 �� �������������������� ������ 25,0 ��������� ������� 5,0 ��',
'���������� ��������, ������������ ����� �����-�����-����-������������� ������� �����������. ��������� GABA-�������������� �������� ������� ��������� � ��� (������ ����������� �� GABA-���������), ��������� ����� �����������������, ������������������, ��������������� � ��������������� ��������.', 
'��������� �������, ������ ��������� �� ��� ����� ��������� � ����� ��� (� ����� ����� ��������� ����� 0.1% ��������� ���� ���������, ������ � ��� �������� � �������� �������� � ����������� ������� �������). ���������� �������������� � ������ � ������. ���������������� � ������ - 80-95%, ���������� ���������������� ���������. �� ����������.',
8, 
2);

INSERT MedicationWithManufacturers VALUES(1, 2);
INSERT MedicationWithManufacturers VALUES(2, 2);

INSERT Sales VALUES (1, 1, 5, 100);
INSERT Sales VALUES (2, 1, 2, 150);
INSERT Sales VALUES (1, 1, 1, 150);

INSERT Suppliers VALUES ('�����������', 7533746);
INSERT Suppliers VALUES ('��������', 7464657);
INSERT Suppliers VALUES ('�������������', 8758749);

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