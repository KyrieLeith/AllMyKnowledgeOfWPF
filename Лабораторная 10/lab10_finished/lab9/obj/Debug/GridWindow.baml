   M S B A M L   `   `   `  ����?  ;lab9, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:lab9lab9  5   	   1clr-namespace:lab9.Converterslab9.Converters  5   	       lab9.GridWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   $localclr-namespace:lab9     5   	   .convclr-namespace:lab9.Converters     5   	     � Title$  
GridWindow��5	   	   $	��600��6   $
��1300��6)    � 	Resources 5
      *   $lab9.Converters.SplitStringConverter   StringConverter��%   &	          5   
   6$   5      .��5      � .+�5   
   �� -   5         ��Name$
 grid��5       �� View 5      �� 5      P�5      �� 5      $��Отправитель��6)    �� DisplayMemberBinding 6>   ��  �� Path$ Sender��� 5      $��Получатель��6)    6=   �� $ 	Recipient��� 5      $��Тема��6)    67   �� $ Subject��� 5      $��
Текст��6)    68   �� $
 Text��� 5      $��Дата��6)    67   �� $
 Date��� 5      $��
Папка��6)    68   �� $ Folder��� 5      $��Статус��6)    69   �� $
 Sent� �� 	Converter# [   �� StringFormat$	 {0}���� 5      $	��Mid��6)    66   �� $	 Mid�$ {0:F2}���� 5      $
��Mime��6)    67   �� $ 
CType.Mime��� 5      $��Charset��6)    6:   �� $ CType.Charset�5      ��5      �� 5        �� 
TargetType" ��6   .�5!      -   5        5"      5$      5%      5&      