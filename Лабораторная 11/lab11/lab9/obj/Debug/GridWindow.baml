   M S B A M L   `   `   `  ����?  ;lab9, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:lab9lab9  5   	   1clr-namespace:lab9.Converterslab9.Converters  5   	       lab9.GridWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   $localclr-namespace:lab9     5   	   .convclr-namespace:lab9.Converters     5   	     � Title$  
GridWindow��5	   	   $	��600��6   $
��1300��6)    � 	Resources 5
      *   $lab9.Converters.SplitStringConverter   StringConverter��%   &	          5   
   6$   5       � DataContext 5         lab9.GridWindowVM  5   
   .��5      �  � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��30 �6   �� 5      $��25 �6   .+�5   
   �� $��0��6   .+�5   
   �� -   5         ��Name$
 grid��5      ��6!   �� *emails+ �� SelectedIndex 6@   �� *SelectedEmail+ �� View 5      �� 5      P�5      �� 5      $��Отправитель��6)    �� DisplayMemberBinding 6>   ��  �� Path$ Sender��� 5      $��Получатель��6)    6=   �� $ 	Recipient��� 5      $��Тема��6)    67   �� $ Subject��� 5      $��
Текст��6)    68   �� $
 Text��� 5      $��Дата��6)    67   �� $
 Date��� 5       $��
Папка��6)    68   �� $ Folder��� 5!      $��Статус��6)    69   �� $
 Sent�	 �� 	Converter#	 [  
 �� StringFormat$	
 {0}���� 5"      $	��Mid��6)    66   �� $	 Mid�$
 {0:F2}���� 5#      $
��Mime��6)    67   �� $ 
CType.Mime��� 5$      $��Charset��6)    6:   �� $ CType.Charset�5&      ��5(      �� 5)       �� 
TargetType" ��6   .�5*      -   5        5+      5-      5.      �� 5/   
   $��1��6    �� Orientation$ 
Horizontal=�6"   $��Center=�6;   .+�50      �� $#��Добавить запись��6   $��5 0 5 0q�6J   $��	0 0 10 10q�6\   ��6/   �� *AddCmd+6\   �� 51      $!��Удалить запись��6   $��5 0 5 0q�6L   $��	0 0 10 10q�6^   ��6.   �� *	DeleteCmd+6^   �� 52      $��Сохранить всё��6   $��5 0 5 0q�6I   $��0 0 0 10q�6[   ��6-   �� *	SaveCmd+6[   53      �� 54   
   $��3��6   .@�55      �� $��Right=�6   .��56      �� ��6   �� $ Message�57      58      59      5:      