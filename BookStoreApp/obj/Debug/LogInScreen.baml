   M S B A M L   `   `   `  ����G  CBookStoreApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:BookStoreAppBookStoreApp  5   	       BookStoreApp.LogInScreen   5   	   b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:BookStoreApp     5   	      MaterialDesignBody#���   5   	   $��Regular"�5	   	   $��13(�5
   	   &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5   	      TextRenderingMode$
 Auto=�5   	     MaterialDesignPaper#���  5   	     MaterialDesignFont#���  5   	    � Title$ Login window��5   	   $	��450��6   $	��429��6+   .��5      � $
��Left=�6   $��0,0,-6.333,-0.333q�6&   $	��429��6A    � ColumnDefinitions 5   
   �� 5      $
��429* �6   �� 5      $��0* �6   �� 5      .+�5   
   �� 
���   �$��1q�6%   $��Right=�69   $��86��6U   $	��Top=�6a   $	��429��6y   
���   �$��3��6�   $��0,0,0.333,0q�6�   �� 5   
   $
��Left=�6   $��66��6+   $��	151,8,0,0q�67   $��icon_logo.png��6J   $	��Top=�6a   $	��111��6y    J� OpacityMask
 �   �6�   �� 5   
   $
��Left=�6   $��31��6+   $��
20,180,0,0q�67   $��icon_username.png��6K   $	��Top=�6f   $��32��6~   
 �   �6�   �� 5   
   $
��Left=�6   $��
60,152,0,0q�6/   $
��Wrap=�6C   $��username��6W   $	��Top=�6g   $��21��6   $	��342��6�   $��20(�6�   $��Berlin Sans FB)�6�   
���   �6�   �� 5   
   -   5         ��Name$ txtUserName��5      $
��Left=�6'   $��33��6B   $��
60,173,0,0q�6N    �� TextWrapping$
 Wrap=�6b   $	��Top=�6v   $	��342��6�   $��20(�6�    J� RenderTransformOrigin$ 0.5,0.5&�6�   $��Berlin Sans FB)�6�   �� 5"   
   $
��Left=�6   $��31��6+   $��
20,249,0,0q�67   $��icon_password.png��6K   $	��Top=�6f   $��32��6~   
 �   �6�   �� 5#   
   $
��Left=�6   $��
60,226,0,0q�6/   $
��Wrap=�6C   $��password��6W   $	��Top=�6g   $��21��6   $	��342��6�   $��20(�6�   $��Berlin Sans FB)�6�   
���   �6�   G� 5$   
   -   5         G�Name$ txtPassword��5$      $
��Left=�6+   $��
60,248,0,0q�6F   $	��Top=�6Z   	 G� 	MaxLength$	 4��6r   $	��342��6�   $��30��6�   $��20(�6�   $ 0.5,0.5&�6�   $��Berlin Sans FB)�6�   �� 5'   
   -   5        
 ��Name$
 BtnLogIn��5'      $��sign in��6#   $
��Left=�65   $��
77,326,0,0q�6P   $	��Top=�6d   $	��119��6|   $��35��6�   ���	#FF060607$��20(�6�   $��Berlin Sans FB)�6�   $��Normal"�6�   ��6  Z� �� 5(   
   -   5        $
 BtnRegister��5(      $��register��6&   $
��Left=�69   $��229,326,0,0q�6T   $	��Top=�6i   $	��113��6�   $��35��6�   ���	#FF060607$��20(�6�   $��Berlin Sans FB)�6�   $��Normal"�6�   ��6  Z� �� 5)   
   $
��Left=�6   $��
38,110,0,0q�6/   $
��Wrap=�6C   $��LOG IN��6W   $	��Top=�6e   $��21��6}   $	��342��6�   $
��Bold"�6�   $��22(�6�    �� TextAlignment$ Center=�6�   
���   �$��Berlin Sans FB)�6�   �� 5*   
   $'��!Application by BigBookShop (2021)��6   $��Center=�6<   $
��Left=�6`   $��	0,391,0,0q�6{   $	��429��6�   $��Berlin Sans FB Demi)�6�   
�������
���   ����	#DDFFFFFF$��3��6�   5+      5,      