   M S B A M L   `   `   `  ����?  ;lab9, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:lab9lab9  5   	       lab9.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   $localclr-namespace:lab9     5   	   -   5          � Title$  
MainWindow��5   	   $	��350��6   $	��525��6)   .��5
      A� -   5         A�Name$ itemGrid��5
   )   $��8q�6    A� Columns$ 2��6    � 	Resources 5   
      
ValueStyle �� 
TargetType �� Triggers �� Binding �� Value �� Property	 �� Value��%  &	        �� 5      " �6'    5      �� 5       6"   �� *Sent+	 False6;   .a�5      ��  �@J�Opacity$		 0.5Q�64   5      �� 5       6"   �� *Sent+ True6;   .a�5      ��  �@J�Opacity$	 1Q�64   5      5      5      .+�5   
   �� $��Отправитель: ��6   #��[  6)   �� 5   
   #��[  5      ��5      �� *Sender+
 �� Mode$
 TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�5      �� 5   
   $��Получатель: ��6   #��[  6(   �� 5   
   #��[  5      ��5      �� *	Recipient+$
 TwoWay=�$ PropertyChanged=�5      �� 5   
   $��Копия: ��6   #��[  6#   �� 5   
   $�� ��6   #��[  5       �� 5!   
   $��
Тема: ��6   #��[  6"   �� 5"   
    �� TextWrapping$
 Wrap=�6]   #��[  5#      ��5"      �� *	Subject+$
 TwoWay=�$ PropertyChanged=�5#      �� 5$   
   $��Текст: ��6   #��[  6#   �� 5%   
   $
 Wrap=�6Z   #��[  5&      ��5%      �� *Text+$
 TwoWay=�$ PropertyChanged=�5&      �� 5'   
   $��
Дата: ��6   #��[  6"   �� 5(   
   #��[  5)      ��5(      �� *Date+$
 TwoWay=�$ PropertyChanged=�5)      �� 5*   
   $��Папка: ��6   #��[  6#   �� 5+   
   #��[  5,      ��5+      �� *Folder+$
 TwoWay=�$ PropertyChanged=�5,      �� 5-   
   $��Отправлено: ��6   #��[  6(   �� 5.   
   #��[  5/       d� 	IsChecked 5.      �� *Sent+$
 TwoWay=�$ PropertyChanged=�5/      �� 50   
   $��Mid: ��6   #��[  6!   �� 51   
   #��[  52      ��51      �� *Mid+$
 TwoWay=�$ PropertyChanged=�52      �� 53   
   $��Mime: ��6   #��[  6"   �� 54   
   #��[  55      ��54      ��  �� Path$ 
CType.Mime�$
 TwoWay=�$ PropertyChanged=�55      �� 56   
   $��	Charset: ��6   #��[  6%   �� 57   
   #��[  58      ��57      �� $ CType.Charset�$
 TwoWay=�$ PropertyChanged=�58      59      5:      