   M S B A M L   `   `   `  ����G  CBookStoreApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:BookStoreAppBookStoreApp  5   	       BookStoreApp.MainWindow   5   	   b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:BookStoreApp     5   	      MaterialDesignBody#���   5   	   $��Regular"�5	   	   $��13(�5
   	   &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5   	      TextRenderingMode$
 Auto=�5   	     MaterialDesignPaper#���  5   	     MaterialDesignFont#���  5   	    � Title$ Manage window��5   	   $	��450��6   $	��429��6,   .��5      � $
��Left=�6   $��0,0,-6.333,-0.333q�6&   $	��429��6A    � ColumnDefinitions 5   
   �� 5      $
��429* �6   �� 5      $��0* �6   �� 5      .+�5   
   �� 
���   �$��1q�6%   $
��Left=�69   $��41��6T   $	��Top=�6`   $	��429��6x   
���   �$��3��6�   �� 5   
   $��Big-Book Shop��6   $
��Left=�6(   $��	154,3,0,0q�6C   $	��Top=�6V   $	��139��6n   $��24(�6z   $
��Bold"�6�   $��ExtraExpanded&�6�   $��36��6�   
�������$��French Script MT)�6�   
���������6�   Z� 6
  �� 5   
   $
��Left=�6   $��31��6+   $��10,5,0,0q�67   $��icon_logo.png��6I   $	��Top=�6`   $��50��6x   �� 5   
   -   5         ��Name$ LblUserName��5      $�� ��6%   $
��Left=�60   $��8,46,0,0q�6K   $	��Top=�6]   $	��409��6u   $��Berlin Sans FB)�6�   ���	#DDFF00006�   �� 5   
   -   5         ��Name$ 
btnSignOut��5      $��Sign Out��6%   $
��Left=�68   $��
319,48,0,0q�6S   $	��Top=�6g   $��92��6   $��22��6�   
���   �$��Berlin Sans FB)�6�   $��14(�6�   6�   �� 5"   
   $
��Left=�6   $��87��6+   $��	39,92,0,0q�67   $	��Top=�6J   $��93��6b   $��icon_customer.png��6m    J� OpacityMask
 �   �6�   �� 5#   
   -   5        $ btnCustomer��5#      $��Custoer Manage��6&   $
��Left=�6?   $��154,110,0,0q�6Z   $	��Top=�6o   $	��229��6�   $��48��6�   
���   �$��Berlin Sans FB)�6�   $��20(�6�   6�   �� 5&   
   $
��Left=�6   $��66��6+   $��
49,181,0,0q�67   $	��Top=�6K   $��66��6c   $��icon_book.png��6n   
 �   � J� RenderTransformOrigin$ -1.126,-0.229&�6�   �� 5'   
   -   5        $ btnBook��5'      $��Book Manage��6"   $
��Left=�68   $��154,191,0,0q�6S   $	��Top=�6h   $	��229��6�   $��48��6�   
���   �$��Berlin Sans FB)�6�   $��20(�6�   6�   �� 5*   
   $
��Left=�6   $��71��6+   $��
41,266,0,0q�67   $	��Top=�6K   $��81��6c   $��icon_buying.png��6n   
 �   �6�   �� 5+   
   -   5        $ btnOrder��5+      $��Order��6#   $
��Left=�63   $��154,274,0,0q�6N   $	��Top=�6c   $	��229��6{   $��48��6�   
���   �$��Berlin Sans FB)�6�   $��20(�6�   6�   �� 5.   
   $'��!Application by BigBookShop (2021)��6   $��Center=�6<   $
��Left=�6`   $��0,391,0,0.333q�6{   $	��429��6�   $��Berlin Sans FB Demi)�6�   
�������
���   ����	#DDFFFFFF$��3��6�   5/      50      