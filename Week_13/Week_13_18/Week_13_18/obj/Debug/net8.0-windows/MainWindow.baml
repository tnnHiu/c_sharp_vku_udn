   M S B A M L   `   `   `  ����E  AWeek_13_18, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Week_13_18
Week_13_18  5   	       Week_13_18.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:Week_13_18     5   	   -   5          � Title$  Manage Categories��5   	   $	��430��6#   $	��420��60    � WindowStartupLocation$ CenterScreen=�5
   	    � 
ResizeMode$ NoResize=�5   	   .��5      ]� $	��Top=�6   $��10q�6(   .+�5   
   �  � RowDefinitions 5      �� 5      $��* �6    �� 5      $��* �6    .+�5      �� 
����ح� �� Orientation$ Vertical=�5      $
��Left=�5      $	��400��5      .+�5      �� -   5        $��lbInstruction��5      
���  ��$��DemiBold"�5      $��20(�5      $��Category Information��5      �� 5      -   5        $��lbCategoryId��5      $��Category Id��5      �� 5      -   5        $��txtCategoryId��5      $
��Left=�5       �� 
IsReadOnly$
 True��5       $��25��5!      $	��300��5"      ��5#      ��  �� Path$ 
CategoryId� �� Mode$ OneWay=� � DataContext 5$      �� 	 �� ElementName$	 lvCategories��$ SelectedItem��� 5%      -   5        $��lbCategoryName��5%      $��Category Name��5&      �� 5'      -   5        $��txtCategoryName��5'      $
��Left=�5(      $��25��5)      $	��300��5*      ��5+      �� $ CategoryName�$ OneWay=� 5,      �� $	 lvCategories��$ SelectedItem��� 5-      $ 
Horizontal=�6   $
��Left=�5.      .+�5/      �� -   5        
 ��Name$
 	btnInsert��5/      $��10q�50      $��80��51      $��Insert��52      53      �� 54      -   5        $
 	btnUpdate��54      $��10q�55      $��80��56      $��Update��57      58      �� 59      -	   5        $
 	btnDelete��59      $��10q�5:      $��80��5;      $��Delete��5<      5=      5>      5?      �� 5@      -
   5        $��lvCategories��5A      $��1��5@      $	��400��5B       �� View 5C      �� 5D      .P�5E      �� $��Category Id��6)    �� Width$	 100��5F   )    �� DisplayMemberBinding 5G   )   �� $ 
CategoryId��� 5H      $��Category Mame��6)   $	 200��5I   )    5J   )   �� $ CategoryName�5K      5M      5N      5O      5P      