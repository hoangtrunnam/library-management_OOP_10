# library-management_OOP_10
đồ án OOP quản lý thư viện sử dụng winform 

cách chạy project:
bước 1: clone về máy.
bước 2: mở project lên.(lúc này không được sửa gì)
bước 3: mở gitbash lên
bước 4: checkout sang nhánh develop bằng câu lệnh: "git checkout develop"
bước 5: từ develop tạo nhánh mới của riêng mình (nhánh này sẽ sử dụng xuyên suốt toàn chương trình)
câu lệnh: "git checkout -b "tên_nhánh_của_mình" "
bước 6: code chức năng được yêu cầu
bước 7: commit code mình làm được và push lên nhánh của mình
bước 8: tạo pull request và assign cho Nam Hoàng
-> 8 bước này là khi chạy pj và tạo nhánh lần đầu, các lần sau sẽ không giống như 8 bước trên.

lưu ý: khi commit code:
- commit theo đúng định dạng, nếu không đúng định dạng sẽ báo lỗi
- format cơ bản
        type(scope?): subject   
        #scope là optional;
- ví dụ: 
    git commit -m 'chore: run tests on travis ci'
    git commit -m 'fix(server): send cors headers'
    git commit -m 'feat(blog): add comment section'
- type cơ bản: 
    + build : build
    + chore : việc vặt
    + docs : tài liệu
    + feat : tính năng
    + fix : fix 
    + perf : hoàn thành
    + refactor : cấu trúc lại
    + revert : hoàn lại
    + style : style
    + test : test
    + add : thêm
* Tạo mới branch: git checkout -b <branch_name>
- branch_name:
+ Nếu làm tính năng không ở trong sprint: features/<task_name>
+ Nếu fix bugs không trong sprint: fixbugs/<task_name>

* Trường hợp chuyển sang nhánh:
- Nhánh local đã được fetch từ remote: git checkout <branch_name>
- Kéo nhánh đã có trên remote: git fetch && git checkout <branch_name>

*****
sửa globalDomain thành tên máy của mình(sẽ hiện khi sql server yêu cầu kết nối. ví du: DESKTOP-62VA20P\HOANGNAM). nhớ phải thêm \ khi paste vào trong code ->  DESKTOP-62VA20P\\HOANGNAM ) 
và tên database bắt buộc phải là lib_Management (file gen code sql sẽ gửi riêng)


