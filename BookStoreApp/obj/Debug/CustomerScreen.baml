   M S B A M L   `   `   `  ����G  CBookStoreApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:BookStoreAppBookStoreApp  5   	   !    BookStoreApp.CustomerScreen   5   	   b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:BookStoreApp     5   	      MaterialDesignBody#���   5   	   $��Regular"�5	   	   $��13(�5
   	   &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5   	      TextRenderingMode$
 Auto=�5   	     MaterialDesignPaper#���  5   	     MaterialDesignFont#���  5   	    � Title$ Custoer Management Screen��5   	   $	��450��6+   $	��429��68   .��5      � $
��Left=�6   $��0,0,-6.333,-0.333q�6&   $	��429��6A    � RowDefinitions 5   
   �� 5       � ColumnDefinitions 5   
   �� 5      $
��429* �6   �� 5      $��0* �6   �� 5      .+�5   
   �� 
���   �$��1q�6%   $
��Left=�69   $��41��6T   $	��Top=�6`   $	��429��6x   
���   �$��3��6�   �� 5   
   $��Big-Book Shop��6   $
��Left=�6(   $��	154,3,0,0q�6C   $	��Top=�6V   $	��139��6n   $��24(�6z   $
��Bold"�6�   $��ExtraExpanded&�6�   $��36��6�   
�������$��French Script MT)�6�   
���������6�   Z� 6
  �� 5   
   $
��Left=�6   $��31��6+   $��10,5,0,0q�67   $��icon_logo.png��6I   $	��Top=�6`   $��50��6x   �� 5   
   -   5         ��Name$ btnMainMenu��5      $��	Main Menu��6&   $
��Left=�6:   $��
307,48,0,0q�6U   $	��Top=�6i   $	��103��6�   $��22��6�   
���   �$��Berlin Sans FB)�6�   $��14(�6�   6�   �� 5    
   -   5        $ 	btnSearch��5       $	��Add��6$   $
��Left=�62   $��
106,68,0,0q�6M   $	��Top=�6a   $��20��6y   $��16��6�   $��Berlin Sans FB)�6�   $��14(�6�   ��5!      �� 5"       �� ImageSource$ icon_search.png��6    j� Stretch$ Uniform=�6;   5$      �� 5'   
   -   5         ��Name$ lblCusId��5'      $
��Left=�6&   $��	10,68,0,0q�6A   $
��Wrap=�6T   $��ID��6h   $	��Top=�6r   $��21��6�   $��31��6�   $��12(�6�   $��Berlin Sans FB)�6�   
���   �6�   �� 5(   
   -   5        	 ��Name$	 txtCusId��5(      $
��Left=�6$   $��21��6?   $��	27,68,0,0q�6K   
 �� TextWrapping$

 Wrap=�6^   $	��Top=�6r   $��74��6�   $��12(�6�    J� RenderTransformOrigin$ 0.5,0.5&�6�   $��Berlin Sans FB)�6�    �� TextAlignment$ Center=�6�   �� 5)   
   $
��Left=�6   $��91��6+   $��
161,49,0,0q�67   $	��Top=�6K   $��93��6c   $��icon_customer.png��6n    J� OpacityMask
 �   �6�   �� 5-   
   -   5        $ lblName��5-      $
��Left=�6%   $��
45,132,0,0q�6@   $
��Wrap=�6T   $
��Name��6h   $	��Top=�6t   $��21��6�   $	��136��6�   $��12(�6�   $��Berlin Sans FB)�6�   
���   �6�   �� 5.   
   -   5        $	 
txtCusName��5.      $
��Left=�6&   $��24��6A   $��
43,145,0,0q�6M   $

 Wrap=�6a   $	��Top=�6u   $	��328��6�   $��12(�6�   $ 0.5,0.5&�6�   $��Berlin Sans FB)�6�   �� 51   
   -   5        $ lblIdCardNo��51      $
��Left=�6)   $��
45,180,0,0q�6D   $
��Wrap=�6X   $��
ID Card No��6l   $	��Top=�6~   $��21��6�   $	��136��6�   $��12(�6�   $��Berlin Sans FB)�6�   
���   �6�   �� 52   
   -   5        $	 txtCusIdCardNo��52      $
��Left=�6*   $��24��6E   $��
43,193,0,0q�6Q   $

 Wrap=�6e   $	��Top=�6y   $	��328��6�   $��12(�6�   $ 0.5,0.5&�6�   $��Berlin Sans FB)�6�   6�   �� 55   
   -	   5        $ lblEmail��55      $
��Left=�6&   $��
43,230,0,0q�6A   $
��Wrap=�6U   $��Email��6i   $	��Top=�6v   $��21��6�   $	��138��6�   $��12(�6�   $��Berlin Sans FB)�6�   
���   �6�   �� 56   
   -
   5        $	 txtCusEmail��56      $
��Left=�6'   $��24��6B   $��
43,243,0,0q�6N   $

 Wrap=�6b   $	��Top=�6v   $	��328��6�   $��12(�6�   $ 0.5,0.5&�6�   $��Berlin Sans FB)�6�   �� 59   
   -   5        $ 
lblAddress��59      $
��Left=�6(   $��
43,278,0,0q�6C   $
��Wrap=�6W   $��Home Address��6k   $	��Top=�6   $��21��6�   $	��138��6�   $��12(�6�   $��Berlin Sans FB)�6�   
���   �6�   �� 5:   
   -   5        $	 txtCusAddress��5:      $
��Left=�6)   $��24��6D   $��
43,291,0,0q�6P   $

 Wrap=�6d   $	��Top=�6x   $	��328��6�   $��12(�6�   $ 0.5,0.5&�6�   $��Berlin Sans FB)�6�   �� 5=   
   $'��!Application by BigBookShop (2021)��6   $��Center=�6<   $
��Left=�6`   $��0,391,0,0.667q�6{   $	��429��6�   $��Berlin Sans FB Demi)�6�   
�������
���   ����	#DDFFFFFF$��3��6�   �� 5@   
   -   5        $ btnAdd��5@      $	��Add��6!   $
��Left=�6/   $��
41,343,0,0q�6J   $	��Top=�6^   $��75��6v   $��31��6�   
���   �$��Berlin Sans FB)�6�   $��14(�6�   6�   �� 5A   
   -   5        $ btnEdit��5A      $
��Edit��6"   $
��Left=�61   $��128,343,0,0q�6L   $	��Top=�6a   $��75��6y   $��31��6�   
���   �$��Berlin Sans FB)�6�   $��14(�6�   6�   �� 5B   
   -   5        $ 	btnDelete��5B      $��Delete��6$   $
��Left=�65   $��216,343,0,0q�6P   $	��Top=�6e   $��75��6}   $��31��6�   
���   �$��Berlin Sans FB)�6�   $��14(�6�   6�   �� 5C   
   -   5        $ btnClear��5C      $��Clear��6#   $
��Left=�63   $��307,343,0,0q�6N   $	��Top=�6c   $��75��6{   $��31��6�   
���   �$��Berlin Sans FB)�6�   $��14(�6�   6�   5D      5E      