﻿
int a1 = 15;
int b1 = 21;
int c1 = 39;

int a2 = 20;
int b2 = 48;
int c2 = 30;

int a3 = 78;
int b3 = 91;
int c3 = 4;

int max = a1;
if (b1 > max) max = b1;
if (c1 > max) max = c1;

if (a2 > max) max = a2;
if (b2 > max) max = b2;
if (c2 > max) max = c2;

if (a3 > max) max = a3;
if (b3 > max) max = b3;
if (c3 > max) max = c3;

Console.WriteLine($"Max number is {max}");
