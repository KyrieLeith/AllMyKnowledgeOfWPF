   M S B A M L   `   `   `  ����
  lab4_1    lab4_1.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  
MainWindow��5   	   $	��350��6   $	��525��6)   .��5      �  � ColumnDefinitions 5   
   �� 5       � RowDefinitions 5	   
   �� 5
      .+�5   
   �� $��0��6   $��0��6"   .+�5   
   �� -   5         ��Name$ SliderFontSize��5   *    � Minimum$ 8Q�6    � Maximum$ 30Q�6   6D   �� 5   
   -   5         ��Name$ Message��5      ��6%   ��  �� ElementName$ SliderFontSize�� �� Path$ Value�ecПример WPF-приложения для демонстрации привязки данных5      �� 5      -   5        	 ��Name$	 t1��5      $
��text��6"   ��6.   �� $ FontSize��$
 Text��� 5      -   5        $	 t2��5      ��6"   �� $ t1��$
 Text�
 �� Mode$
 TwoWay=���6Z   �� $ FontSize��$
 Text��� 5      -   5        $ slider1��5   .   $ 8Q�6   $ 30Q�6!    � Value 6?   �� $ FontSize��$
 Text�$
 TwoWay=��� 5      -   5        $ slider2��5   .   $ 8Q�6   $ 30Q�6!    6?   �� $ slider1��$ Value��� 5      -   5        $	 FontSize��5      5      5      5      