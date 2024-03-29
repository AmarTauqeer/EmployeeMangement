'use client'
import Link from "next/link";
import { useState, React } from "react";
import { FaRegEnvelope } from "react-icons/fa";
import { MdLockOutline } from "react-icons/md";
import { BsPersonFill } from "react-icons/bs";

import { useRouter } from "next/navigation";
import { toast } from "sonner";

export default function Signup() {
  const url = process.env.NEXT_PUBLIC_URL;
  const [email, setEmail] = useState("amar.tauqeer@hotmail.com");
//   const [name, setName] = useState("tauqeer");
  const [password, setPassword] = useState("Tauqeer@786");
//   const [rePassword, setRePassword] = useState("tauqeer");
  const [message, setMessage] = useState("");
  const router = useRouter();
  // const [confirmPassword, setConfirmPassword] = useState("");

  const handleSubmit = async (e) => {
    e.preventDefault();

    const res = await fetch(`${url}/register`, {
      method: "POST",
      headers: {
        "Content-type": "application/json; charset=UTF-8",
      },
      body: JSON.stringify({
        email,
        // name,
        password,
        // confirm_password: rePassword,
        // username: email,
        // first_name:name,
      }),
    });
    // console.log(res);
    if (await res.status == 400) {
      toast.error("Bad request");
      return false;
    }
    console.log(res)
    const status = await res.status
    // console.log(status)
    if (status==200) {
      setEmail("");
    //   setName("");
      setPassword("");
      toast.success("Account is created.");
      // setMessage("An email for activation is sent to "+email)
      router.push("/");
    }
    
  };

  return (
    <form onSubmit={handleSubmit}>
      <div className="flex flex-col text-center items-center justify-center h-screen">
        <div className="bg-white rounded-2xl shadow-2xl flex">
          <div className="w-64 md:w-[450px] p-5">
            {/* sign in section */}
            <div className="text-left font-bold ml-6 md:ml-0">
              <span className="text-green-500">Employee</span>Management
            </div>

            <div className="py-12">
              <h2 className="text-sm uppercase ml-4 md:ml-0 md:text-2xl font-bold text-green-500 mb-1">
                Register
              </h2>
              <div className="border-2 w-[85px] border-green-500 inline-block mb-12"></div>
              {/* <div className="flex flex-col items-center mb-3">
                <div className="bg-gray-100 w-[250px] md:w-80 lg:w-80 flex items-center">
                  <BsPersonFill className="text-gray-400 m-2" />
                  <input
                    type="text"
                    value={name}
                    onChange={(e) => setName(e.target.value)}
                    placeholder="name"
                    className="bg-gray-100 outline-none text-sm flex-1"
                  />
                </div>
              </div> */}
              <div className="flex flex-col items-center">
                <div className="bg-gray-100 w-[250px] md:w-80 lg:w-80 flex items-center">
                  <FaRegEnvelope className="text-gray-400 m-2" />
                  <input
                    type="email"
                    value={email}
                    onChange={(e) => setEmail(e.target.value)}
                    placeholder="email"
                    className="bg-gray-100 outline-none text-sm flex-1"
                  />
                </div>
              </div>
              <div className="flex flex-col items-center mt-3 mb-3">
                <div className="bg-gray-100 w-[250px] md:w-80 lg:w-80 flex items-center">
                  <MdLockOutline className="text-gray-400 m-2" />
                  <input
                    type="password"
                    value={password}
                    onChange={(e) => setPassword(e.target.value)}
                    placeholder="password"
                    className="bg-gray-100 outline-none text-sm flex-1"
                  />
                </div>
              </div>
              {/* <div className="flex flex-col items-center mb-5">
                <div className="bg-gray-100 w-[250px] md:w-80 lg:w-80 flex items-center">
                  <MdLockOutline className="text-gray-400 m-2" />
                  <input
                    type="password"
                    value={rePassword}
                    onChange={(e) => setRePassword(e.target.value)}
                    placeholder="retype password"
                    className="bg-gray-100 outline-none text-sm flex-1"
                  />
                </div>
              </div> */}
              <div className="flex flex-col items-center mt-3 mb-5">
                <div className="flex">
                  <div className="text-sm mr-2">Already have an account</div>
                  <div>
                    <Link
                      className="flex justify-end text-sm underline text-blue-600"
                      href="/"
                    >
                      Login?
                    </Link>
                  </div>
                </div>
              </div>
              <a
                onClick={handleSubmit}
                href="#"
                className="bg-green-500 w-48 md:w-80 lg:w-80 text-white text-sm md:text-lg px-6 md:px-8 py-1 inline-block font-semibold hover:bg-green-400"
              >
                Register
              </a>
              <div className="flex items-center justify-center">
                <p
                  className={
                    message === "user with this email already exists." ||
                    message ===
                      "This password is too short. It must contain at least 8 characters." ||
                    message === "The two password fields didn't match." ||
                    message === "This field may not be blank."
                      ? "bg-red-500 text-lg text-white"
                      : "bg-green-500 text-lg text-white"
                  }
                >
                  {message}
                </p>
              </div>
            </div>
          </div>
        </div>
      </div>
    </form>
  );
}