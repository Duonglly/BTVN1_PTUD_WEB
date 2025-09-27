# BTVN1_PTUD_WEB

# BÀI TẬP VỀ NHÀ 01:
## TẠO SOLUTION GỒM CÁC PROJECT SAU:
### DLL đa năng, keyword: c# window library -> Class Library (.NET Framework) bắt buộc sử dụng .NET Framework 2.0: giải bài toán bất kỳ, độc lạ càng tốt, phải có dấu ấn cá nhân trong kết quả, biên dịch ra DLL. DLL độc lập vì nó ko nhập, ko xuất, nó nhận input truyền vào thuộc tính của nó, và trả về dữ liệu thông qua thuộc tính khác, hoặc thông qua giá trị trả về của hàm. Nó độc lập thì sẽ sử dụng được trên app dạng console (giao diện dòng lệnh - đen sì), cũng sử dụng được trên app desktop (dạng cửa sổ), và cũng sử dụng được trên web form (web chạy qua iis).
### Console app, bắt buộc sử dụng .NET Framework 2.0, sử dụng được DLL trên: nhập được input, gọi DLL, hiển thị kết quả, phải có dấu án cá nhân. keyword: c# window Console => Console App (.NET Framework), biên dịch ra EXE
### Windows Form Application, bắt buộc sử dụng .NET Framework 2.0**, sử dụng được DLL đa năng trên, kéo các control vào để có thể lấy đc input, gọi DLL truyền input để lấy đc kq, hiển thị kq ra window form, phải có dấu án cá nhân; keyword: c# window Desktop => Windows Form Application (.NET Framework), biên dịch ra EXE
### Web đơn giản, bắt buộc sử dụng .NET Framework 2.0, sử dụng web server là IIS, dùng file hosts để tự tạo domain, gắn domain này vào iis, file index.html có sử dụng html css js để xây dựng giao diện nhập được các input cho bài toán, dùng mã js để tiền xử lý dữ liệu, js để gửi lên backend. backend là api.aspx, trong code của api.aspx.cs thì lấy được các input mà js gửi lên, rồi sử dụng được DLL đa năng trên. kết quả gửi lại json cho client, js phía client sẽ nhận được json này hậu xử lý để thay đổi giao diện theo dữ liệu nhận dược, phải có dấu án cá nhân. keyword: c# window web => ASP.NET Web Application (.NET Framework) + tham khảo link chatgpt thầy gửi. project web này biên dịch ra DLL, phải kết hợp với IIS mới chạy được.
# Các bước triển khai
## Tạo Solution + Project DLL đa năng (PTB2_Library):
### Solution là “khung” chứa toàn bộ các project con.

### PTB2_Library là Class Library (DLL) – chứa toàn bộ logic xử lý, hàm, lớp, thuật toán dùng chung.

 ### Mục đích:

-Tách code xử lý logic ra khỏi giao diện để dễ tái sử dụng.

-Dùng chung được cho Console App, WinForms hay Web App mà không cần viết lại.
<img width="248" height="99" alt="image" src="https://github.com/user-attachments/assets/26edb8d6-a4de-4080-9ad9-bc595d39e922" />


## Console App (PTB2_Console):
### Tạo 1 project Console để test nhanh thư viện PTB2_Library.

-Không có giao diện, chỉ chạy trên màn hình dòng lệnh.

-Dùng để kiểm tra chức năng lõi hoạt động đúng chưa trước khi làm GUI.
<img width="417" height="130" alt="image" src="https://github.com/user-attachments/assets/1e54afea-b491-4ac2-9f77-8c92d897ec29" />

## Thêm tham chiếu đến DLL:
### Muốn dùng code từ PTB2_Library trong Console App, WinForms hay Web App → phải thêm tham chiếu (Add Reference) tới thư viện đó.
<img width="1021" height="716" alt="image" src="https://github.com/user-attachments/assets/45c0b634-b8ce-4124-abea-1518aa952651" />

## Windows Forms App (PTB2_WindowsForms):
### Tạo project WinForms để xây dựng giao diện người dùng dạng cửa sổ (nút bấm, textbox, label…).

### Mục tiêu:

-Giao diện thân thiện cho người dùng cuối.

-Gọi lại các hàm trong DLL để xử lý dữ liệu nhập vào từ form.
<img width="918" height="520" alt="image" src="https://github.com/user-attachments/assets/21584fa7-0fc6-40fa-bdd7-955f51c2b81b" /><img width="303" height="276" alt="image" src="https://github.com/user-attachments/assets/84f73294-38ed-4a69-b6b9-1952a652d7ce" />


## Thêm tham chiếu đến DLL: <img width="994" height="706" alt="image" src="https://github.com/user-attachments/assets/563db4cb-fbac-4564-8582-8b5a8c188dd1" />

## Web App (PTB2_Web) với ASP.NET Web Forms:
### Tạo project Web dạng Web Forms (.aspx) – đây là phiên bản web của chương trình.

-Cho phép người dùng nhập dữ liệu và xem kết quả trên trình duyệt.

-Vẫn tái sử dụng logic từ PTB2_Library
<img width="346" height="220" alt="image" src="https://github.com/user-attachments/assets/1153796c-6c2a-47d9-9afa-9b78c7e5a500" />

## Tạo file Index.html:
-Tạo một trang HTML tĩnh làm trang chủ hoặc giao diện frontend ban đầu.

-Có thể chứa form để người dùng nhập liệu và gửi request đến API hoặc api.aspx.
<img width="1920" height="1080" alt="image" src="https://github.com/user-attachments/assets/2b3131f4-684e-4355-a8fa-7b4f98a08d00" />

## Tạo file api.aspx:
### Đây là API endpoint – nơi xử lý dữ liệu từ trình duyệt gửi lên và trả kết quả lại.

-Thường được dùng khi frontend (HTML/JS) gọi API bằng AJAX.

- trong gọi lại các hàm xử lý từ PTB2_Library.
<img width="1920" height="1080" alt="image" src="https://github.com/user-attachments/assets/9e24f939-7fce-4698-8923-bd9a160103b8" />
## Hình ảnh kiểm ngiệm 
### Vô Nghiệm:
<img width="965" height="1012" alt="image" src="https://github.com/user-attachments/assets/46ec096f-6fc7-4c98-9bb7-dd61ae242670" />
### 2 nghiệm
<img width="961" height="1009" alt="image" src="https://github.com/user-attachments/assets/809c6a17-3303-4e2f-a71c-9fae63530b8d" />
### Vô số nghiệm
<img width="950" height="1018" alt="image" src="https://github.com/user-attachments/assets/dff2ed5e-7aab-4d9d-9c8d-8f1c7f2d18c2" />


